using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {

    public float tumble;
    public Rigidbody rb;
    void Start()
    {
        rb.angularVelocity = Random.insideUnitSphere * tumble; 
    }
}
