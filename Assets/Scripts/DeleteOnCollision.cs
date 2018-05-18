using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOnCollision : MonoBehaviour {

    public GameObject deleteObject;

    public GameObject collideObject;

    void OnCollisionEnter(Collision collision) {

        if (collision.gameObject == collideObject) {

            Destroy(deleteObject);

        }

    }

}
