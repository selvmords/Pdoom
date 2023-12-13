using UnityEngine;

public class WeaponPos : MonoBehaviour
{
    public Transform weaPos;

    private void Update()
    {
        transform.position = weaPos.position;
    }
}