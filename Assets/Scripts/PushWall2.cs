using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushWall2 : MonoBehaviour {

    //The maximum amount the object can move
    public float MaxMoveAmountX;
    public float MaxMoveAmountY;
    public float MaxMoveAmountZ;

    //How far it has already moved in X, Y and Z
    float movedSoFarX = 0;
    float movedSoFarY = 0;
    float movedSoFarZ = 0;

    bool WallPush = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {

        //The amount the object is supposed to move this frame in X, Y and Z
        float amountToMoveThisFrameX = 10 * Time.deltaTime;
        float amountToMoveThisFrameY = 10 * Time.deltaTime;
        float amountToMoveThisFrameZ = 10 * Time.deltaTime;

        GameObject PusherWall = GameObject.Find("Pushing Wall");
        PushWall MoveComplete = PusherWall.GetComponent<PushWall>();
        WallPush = PushWall.MoveComplete;

        //The calculation for the object to move
        if (movedSoFarX < MaxMoveAmountX && WallPush == true)
        {
            transform.Translate(amountToMoveThisFrameX, 0, 0);
            movedSoFarX += amountToMoveThisFrameX;
        }

        if (movedSoFarY < MaxMoveAmountY && WallPush == true)
        {
            transform.Translate(0, amountToMoveThisFrameY, 0);
            movedSoFarY += amountToMoveThisFrameY;
        }

        if (movedSoFarZ < MaxMoveAmountZ && WallPush == true)
        {
            transform.Translate(0, 0, amountToMoveThisFrameZ);
            movedSoFarZ += amountToMoveThisFrameZ;
        }

    }
}
