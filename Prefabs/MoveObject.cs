using UnityEngine;

public class MoveObject : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);
        }
    }
}