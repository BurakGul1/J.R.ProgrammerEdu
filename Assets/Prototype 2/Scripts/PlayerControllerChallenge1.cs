using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerChallenge1 : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 120.0f;
    private float verticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.left * Time.deltaTime * turnSpeed * verticalInput);
    }
}
