using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlankFall2 : MonoBehaviour {

    public Rigidbody rb;

    bool inTrigger = false;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        GameObject FallTrigger = GameObject.Find("PlankFallTrigger2");
        PlankFallTriggerScript2 plankFallTriggered = FallTrigger.GetComponent<PlankFallTriggerScript2>();
        inTrigger = PlankFallTriggerScript2.plankFallTriggered;

        if (inTrigger == true)
        {
            rb.isKinematic = false;
        }

    }
}
