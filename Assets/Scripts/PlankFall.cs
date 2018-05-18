using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankFall : MonoBehaviour {

    public Rigidbody rb;

    bool inTrigger = false;
    
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        GameObject FallTrigger = GameObject.Find("PlankFallTrigger");
        PlankFallTriggerScript plankFallTriggered = FallTrigger.GetComponent<PlankFallTriggerScript>();
        inTrigger = PlankFallTriggerScript.plankFallTriggered;

        if (inTrigger == true)
        {
            rb.isKinematic = false;
        }

    }
}
