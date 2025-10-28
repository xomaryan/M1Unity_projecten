using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public float distance = 4f;
    public float height = 2f;
    public float rotationSpeed = 5f;

    private float currentX = 0f;
    private float currentY = 0f;
    public float minY = -20f;
    public float maxY = 60f;

    private void LateUpdate()
    {
        currentX += Input.GetAxis("Mouse X") * rotationSpeed;
        currentY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        currentY = Mathf.Clamp(currentY, minY, maxY);

        Vector3 direction = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = target.position + rotation * direction + new Vector3(0, height, 0);

        transform.LookAt(target.position + Vector3.up * 1.5f);
    }
}
