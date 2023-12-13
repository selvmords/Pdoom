using UnityEngine;

public class WeaponClip : MonoBehaviour
{
    public Transform cameraTransform;

    public float bobbingSpeed = 1.0f;
    public float bobbingAmount = 0.1f;

    private float originalY;

    void Start()
    {
        originalY = transform.localPosition.y;
        cameraTransform = Camera.main.transform;
    }


    void Update()
    {
        transform.position = cameraTransform.position;
        transform.rotation = cameraTransform.rotation;


        float newY = originalY + Mathf.Sin(Time.time * bobbingSpeed) * bobbingAmount;

        // Update the weapon's local position within the camera space
        Vector3 newPosition = transform.localPosition;
        newPosition.y = newY;

        // Apply the bobbing motion relative to the camera's forward axis
        transform.localPosition = newPosition;
    }
}