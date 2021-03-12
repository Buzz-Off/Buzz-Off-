using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_fly : MonoBehaviour
{

    public float x_force;
    public float y_force;
    public float z_force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction;

        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector3.up;
            gameObject.GetComponent<Rigidbody>().AddForce(direction * y_force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector3.down;
            gameObject.GetComponent<Rigidbody>().AddForce(direction * y_force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction = Vector3.left;
            gameObject.GetComponent<Rigidbody>().AddForce(direction * x_force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction = Vector3.right;
            gameObject.GetComponent<Rigidbody>().AddForce(direction * x_force * Time.deltaTime);
        }
    }
}
