using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    public float xy_speed;
    public float z_speed;
    public float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {


    }


    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, 0, 0);

       if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f * xy_speed * Time.deltaTime, transform.position.z);
            gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(-40, transform.rotation.y, transform.rotation.z), rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y - 0.01f * xy_speed * Time.deltaTime, transform.position.z);
            gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(40, transform.rotation.y, transform.rotation.z), rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction = direction + Vector3.left * 0.01f * xy_speed * Time.deltaTime;
            gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(transform.rotation.x, -40, transform.rotation.z), rotateSpeed * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(transform.position.x + 0.01f * xy_speed * Time.deltaTime, transform.position.y, transform.position.z);
            gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(transform.rotation.x, 40, transform.rotation.z), rotateSpeed * Time.deltaTime);
        }
        if (Input.GetMouseButton(0))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.01f * z_speed * Time.deltaTime);
        }
        if (Input.GetMouseButton(1))
        {
            gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.01f * z_speed * Time.deltaTime);
        }

        gameObject.transform.position += direction; //force
    }
}
