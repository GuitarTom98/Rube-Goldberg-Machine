using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    //Used to determine which camera it is currently on and when to switch to another
    public static int ChangeCamera = 0;

    //Used to determine when the object has entered the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        /*
        Determines if the object that has entered the zone has 
        the "Camera Trigger" tag and therefore if it can trigger a camera change
        */
        if (other.gameObject.tag == "CameraTrigger") {

            ChangeCamera = ChangeCamera + 1;
 
        }
    }


}
