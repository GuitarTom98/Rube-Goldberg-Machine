using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour {

    public float MaxMoveAmount;

    float movedSoFar = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float amountToMoveThisFrame = 2 * Time.deltaTime;
        
        if (movedSoFar < MaxMoveAmount)
        {
            transform.Translate(amountToMoveThisFrame, 0, 0);
            movedSoFar += amountToMoveThisFrame;
        }

	}
}
