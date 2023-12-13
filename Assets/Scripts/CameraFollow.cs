using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform camPos;

    private void Update()
    {
        transform.position = camPos.position;
    }
}