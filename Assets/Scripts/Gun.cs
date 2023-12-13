using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    [Header("References")]
    [SerializeField] GunData gunData;
    [SerializeField] private Transform muzzle;
    public TextMeshProUGUI ammoText;
    [SerializeField] Transform weaponTransform;

    float timeSinceLastShot;
    [SerializeField] float rotationSpeed = 180f;
    [SerializeField] float spinTime = 1.50f;

    void Start()
    {
        PlayerShoot.shootInput += Shoot;
        PlayerShoot.reloadInput += StartReload;
    }

    private void StartReload()
    {
        if(!gunData.reloading)
        {
            StartCoroutine(Reload());
            //StartCoroutine(SpinWeapon());
        }
    }

    IEnumerator SpinWeapon()
    {
        float elapsedTime = 0f;

        while (elapsedTime < spinTime)
        {
            weaponTransform.transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);

            elapsedTime += Time.deltaTime;

            yield return null;
        }
    }

    private IEnumerator Reload()
    {
        gunData.reloading = true;

        yield return new WaitForSeconds(gunData.reloadTime);

        gunData.currentAmmo = gunData.magSize;

        gunData.reloading = false;
    }

    private bool CanShoot() => !gunData.reloading && timeSinceLastShot > 1f / (gunData.fireRate / 60f);

    public void Shoot()
    {
        if(gunData.currentAmmo > 0)
        {
            if(CanShoot())
            {
                if(Physics.Raycast(muzzle.position, transform.forward, out RaycastHit hitInfo, gunData.maxDistance))
                {
                    IDamageable damegable = hitInfo.transform.GetComponent<IDamageable>();
                    damegable?.Damage(gunData.damage);
                }

                gunData.currentAmmo--;
                timeSinceLastShot = 0f;
                OnGunShot();
            }
        }
    }

    private void Update() {
        timeSinceLastShot += Time.deltaTime;

        Debug.DrawRay(muzzle.position, muzzle.forward);
    }

    void OnGunShot()
    {

    }

}
