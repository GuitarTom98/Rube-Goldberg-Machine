using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceScript : MonoBehaviour {

    public Rigidbody forceObject;

    public GameObject collideObject;

    public float thrust;

    void Start()
    {
        forceObject = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject == collideObject)
        {

            forceObject.AddForce(transform.forward * thrust);

        }
   
    }
}
