using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    Rigidbody myRigidBogy; 

    // Start is called before the first frame update
    void Start()
    {
        myRigidBogy = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Horizontal");
        float horizontal = -1*Input.GetAxis("Vertical");

        myRigidBogy.AddForce( new Vector3(horizontal, 0, vertical) * speed);
    }
}
