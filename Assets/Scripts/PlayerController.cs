using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //We'll move the vehicle forward.
        //transform.Translate(0, 0, 1);
        //Moves the car based on vertical input
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
        //Rotates the car based on horizontal input 
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
    }
}
