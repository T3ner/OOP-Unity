using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    private int velocity = 5;
    Rigidbody rb;
    private float border = 55.0f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.AddForce(Vector3.forward*velocity);
        if(transform.position.z > border)
        {
            Destroy(gameObject);
        }
    }
}
