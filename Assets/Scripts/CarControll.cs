using UnityEngine;
using System.Collections;

public class CarControll : MonoBehaviour
{

    Rigidbody rb;
    public float rotateSpeed = 20;
    public float speed = 10;
    public Camera cam;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        cam.transform.LookAt(transform);
        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(-Vector3.up * rotateSpeed * Time.deltaTime);

    }

    void FixedUpdate()
    {
        rb.AddForce(Vector3.right * speed);
    }
}
