using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;

}
public class PlayerController : MonoBehaviour {
    public Rigidbody rb;
    public float speed;
    public float tilt;
    public Boundary boundary;
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal*speed, 0.0f, moveVertical*speed);
        rb.velocity = movement;

        rb.position = new Vector3
            (
                Mathf.Clamp(rb.position.x,boundary.xMin,boundary.xMax), 
                0.0f, 
                Mathf.Clamp(rb.position.z,boundary.zMin,boundary.zMax)
            );
        rb.rotation = Quaternion.Euler(0.0f,0.0f,rb.velocity.x*-tilt);
    }
}
