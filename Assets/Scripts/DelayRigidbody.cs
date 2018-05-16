using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayRigidbody : MonoBehaviour {

    public Rigidbody rb;
    public Rigidbody target;
    //public Transform target;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "SeesawRotation")
        {
            if (target != null)
            {
                target.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            }
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().isKinematic = false;
            Debug.Log(gameObject.name + " " + GetComponent<Rigidbody>().isKinematic);
           // Debug.Log("test");
        }
        
    }
    // Update is called once per frame
    void Update () {
		
	}
}
