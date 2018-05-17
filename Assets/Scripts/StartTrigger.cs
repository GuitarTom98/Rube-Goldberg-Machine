using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTrigger : MonoBehaviour {
    
    //The maximum amount the object can move
    public float MaxMoveAmount;

    //How far it has already moved
    float movedSoFar = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //The amount the object is supposed to move this frame
        float amountToMoveThisFrame = 2 * Time.deltaTime;
        
        //The calculation for the object to move
        if (movedSoFar < MaxMoveAmount)
        {
            transform.Translate(amountToMoveThisFrame, 0, 0);
            movedSoFar += amountToMoveThisFrame;
        }

	}
}
