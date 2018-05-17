using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushWall : MonoBehaviour {

    //The maximum amount the object can move
    public float MaxMoveAmountX;
    public float MaxMoveAmountY;
    public float MaxMoveAmountZ;

    //How far it has already moved in X, Y and Z
    float movedSoFarX = 0;
    float movedSoFarY = 0;
    float movedSoFarZ = 0;

    bool InTrigger = false;

    public bool MoveComplete = false;

    // Update is called once per frame
    void Update()
    {

        //The amount the object is supposed to move this frame in X, Y and Z
        float amountToMoveThisFrameX = -2 * Time.deltaTime;
        float amountToMoveThisFrameY = -2 * Time.deltaTime;
        float amountToMoveThisFrameZ = -2 * Time.deltaTime;

        GameObject WallPushTrigger = GameObject.Find("PushTrigger");
        PushWallTrigger Triggered = WallPushTrigger.GetComponent<PushWallTrigger>();
        InTrigger = PushWallTrigger.Triggered;

        //The calculation for the object to move
        if (movedSoFarX < MaxMoveAmountX && InTrigger == true)
        {
            transform.Translate(amountToMoveThisFrameX, 0, 0);
            movedSoFarX -= amountToMoveThisFrameX;
        }

        if (movedSoFarY < MaxMoveAmountY && InTrigger == true)
        {
            transform.Translate(0, amountToMoveThisFrameY, 0);
            movedSoFarY -= amountToMoveThisFrameY;
        }

        if (movedSoFarZ < MaxMoveAmountZ && InTrigger == true)
        {
            transform.Translate(0, 0, amountToMoveThisFrameZ);
            movedSoFarZ -= amountToMoveThisFrameZ;
        }

        if (movedSoFarX == MaxMoveAmountX && movedSoFarY == MaxMoveAmountY && movedSoFarZ == MaxMoveAmountZ) {

            MoveComplete = true;

        }

    }
}
