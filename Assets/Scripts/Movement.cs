using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 100;

    void Update()
    {
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");

        Vector3 movement = new(movementY, 0, movementX);

        transform.Rotate(speed * Time.deltaTime * movement);
    }
}

