using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float x_force;
    public float y_force;
    public float z_force;


    private Rigidbody rb;
    private Vector3 angularSpeed;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }


    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        Quaternion rotation = Quaternion.Euler(angularSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W))
        {
            direction = direction + Vector3.up;
            gameObject.GetComponent<Rigidbody>().AddForce(direction * y_force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction = direction + Vector3.down;
            gameObject.GetComponent<Rigidbody>().AddForce(direction * y_force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction = direction + Vector3.left;
            gameObject.GetComponent<Rigidbody>().AddForce(direction * x_force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction = direction + Vector3.right;
            gameObject.GetComponent<Rigidbody>().AddForce(direction * x_force * Time.deltaTime);
        }
        if (Input.GetMouseButton(0))
        {
            direction = direction + Vector3.forward;
            gameObject.GetComponent<Rigidbody>().AddForce(direction * z_force * Time.deltaTime);
        }
        if (Input.GetMouseButton(1))
        {
            direction = direction + Vector3.back;
            gameObject.GetComponent<Rigidbody>().AddForce(direction * z_force * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            angularSpeed = new Vector3(0, -50, 0);
            rb.MoveRotation(rb.rotation * rotation);

        }
        if (Input.GetKey(KeyCode.E))
        {
            angularSpeed = new Vector3(0, 50, 0);
            rb.MoveRotation(rb.rotation * rotation);

        }





    }
}
