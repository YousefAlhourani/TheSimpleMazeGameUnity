using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 inputVec;
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        inputVec=new Vector3(Input.GetAxis("Horizontal")*10f,rb.velocity.y,Input.GetAxis("Vertical")*10f);
        transform.LookAt(transform.position+new Vector3(inputVec.x,0,inputVec.z));

        
    }

    private void FixedUpdate()
    {
        rb.velocity=inputVec;
    }

    
}
