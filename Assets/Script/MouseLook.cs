using UnityEngine;

public class CarCameraController : MonoBehaviour
{
    public Transform car; // Assign your car GameObject here
    public float mouseSensitivity = 100f;
    public float distance = 5f;  // Distance behind the car
    public float height = 2f;    // Height above the car
    public float rotationSmoothness = 5f;

    private float yaw = 0f;  // Horizontal rotation
    private float pitch = 0f; // Vertical rotation

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock cursor in the game
    }

    void LateUpdate()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Update rotation values
        yaw += mouseX;
        pitch -= mouseY;
        pitch = Mathf.Clamp(pitch, -30f, 60f); // Limit vertical angle

        // Calculate new camera position
        Quaternion targetRotation = Quaternion.Euler(pitch, yaw, 0f);
        Vector3 targetPosition = car.position - targetRotation * Vector3.forward * distance + Vector3.up * height;

        // Smoothly move and rotate the camera
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * rotationSmoothness);
        transform.LookAt(car.position + Vector3.up * 1f); // Look at the car
    }
}
