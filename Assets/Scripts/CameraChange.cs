using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public static int ChangeCamera = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CameraTrigger") {

            ChangeCamera = ChangeCamera + 1;
 
        }
    }


}
