using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 40f;
    private float horizontalInput;
    private float verticalInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(0, 0, 1 * speed * Time.deltaTime);
        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        //transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        if (verticalInput > 0) 
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        }
        if (verticalInput < 0)
            {
            transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
            }
    }
}
