using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed;
    public float Horizontalinput;
    public float forwardinput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");
        
         // move the vehicle forward
         transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardinput);
         transform.Rotate(Vector3.up, turnSpeed * Horizontalinput);
    }
}
