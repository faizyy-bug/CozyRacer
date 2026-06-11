using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public Transform car;
    Vector3 offset =  new Vector3(0, 4, -8);

    void Start()
    {
        offset = transform.position - car.position;
    }

    void LateUpdate()
    {
        transform.position = car.position  + car.rotation * offset;
        transform.LookAt(car.position + Vector3.up * 5f);
    }
}
