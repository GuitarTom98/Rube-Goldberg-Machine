using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayRigidbody : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SeesawRotation")
        {
            rb.isKinematic = false;
        }
        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
