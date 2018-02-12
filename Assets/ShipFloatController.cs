using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipFloatController : MonoBehaviour
{


    public bool turnForward = false;
    public float maxSpeed = 10;
    public float mapK = 15;
    private Quaternion newRotation = Quaternion.AngleAxis(0, Vector3.up);
    public float speedAcceleration = 0.01f;
    public Transform helmTransform;
    public float leaverValue = 0;

    private float currentPower = 0;

    public void flopTurnForward()
    {
        if (turnForward)
        {
            turnForward = false;
        }
        else
        turnForward = true;

    }


    float mapAngleFromHelm(Quaternion helmRotation)
    {
        float angle = helmRotation.eulerAngles.x;
        if (angle > 180)
        {
            angle -= 360;
        }
        angle = angle / mapK;
        return angle;
    }


    void Update()
    {
        if (leaverValue != 0)
        {
            this.transform.Rotate(0, mapAngleFromHelm(helmTransform.localRotation) * Time.deltaTime, 0);
        }

        
            currentPower = Mathf.Lerp(currentPower, leaverValue, speedAcceleration);
        
        this.transform.Translate(Vector3.forward * maxSpeed * currentPower * Time.deltaTime);
       





    }




}
