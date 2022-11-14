using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 10f;
    public float horizontalInput;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(0, 0, 1 * speed * Time.deltaTime);
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
