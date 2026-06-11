using UnityEngine;

public class CarController : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardAndReverseSpeed;
    public float SidewaysSpeed;

    void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal") * moveInput;
        Vector3 newPosition = rb.position + (transform.forward * moveInput * ForwardAndReverseSpeed * Time.fixedDeltaTime);
        Quaternion newRotation = rb.rotation * Quaternion.Euler(0, turnInput * SidewaysSpeed * Time.fixedDeltaTime, 0);

        rb.MoveRotation(newRotation);
        rb.MovePosition(newPosition);
    }
}
