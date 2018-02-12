using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotator : MonoBehaviour {


    public Transform wheel;
    public enum Axis {X,Y,Z};
    public Axis axis = Axis.X;
    public float rotationK = 1;

    void Update()
    {
        Vector3 t = this.transform.localRotation.eulerAngles;
        
        if (axis == Axis.X)
        {
            t.x = wheel.eulerAngles.x;
            this.transform.localRotation = Quaternion.Euler(t);

        }
        else if (axis == Axis.Y)
        {
            t.y = wheel.eulerAngles.x;
            this.transform.localRotation = Quaternion.Euler(t);
        }
        else
        {
            t.z = wheel.eulerAngles.x;
            this.transform.localRotation = Quaternion.Euler(t);
            


        }

    }



}
