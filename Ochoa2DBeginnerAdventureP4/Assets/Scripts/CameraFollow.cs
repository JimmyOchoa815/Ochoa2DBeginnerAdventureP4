using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target;      // Player
    public float smoothSpeed = 0.3f;
    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        // Keep camera's Z value so it doesn't move forward/backward
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothSpeed);
    }
}
