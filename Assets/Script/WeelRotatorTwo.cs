using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeelRotatorTwo : MonoBehaviour {

    public Transform wheel;
    public enum Axis { X, Y, Z };
    public Axis axis = Axis.X;
    public float rotationK = 1;

    Vector3 mapEulerToInspectorAngle(Quaternion rotation)
    {
        float angleX = rotation.eulerAngles.x;
        if (angleX > 180)
        {
            angleX -= 360;
        }
        float angleY = rotation.eulerAngles.y;
        if (angleY > 180)
        {
            angleY -= 360;
        }
        float angleZ = rotation.eulerAngles.z;
        if (angleZ > 180)
        {
            angleZ -= 360;
        }
        return new Vector3(angleX, angleY, angleZ);
    }


    void Update()
    {
        //Vector3 t = this.transform.localRotation.eulerAngles; 

        Vector3 temp = mapEulerToInspectorAngle(wheel.localRotation);




        if (axis == Axis.X)
        {
            //t.x = wheel.eulerAngles.x; 
            this.transform.localRotation = Quaternion.AngleAxis(temp.y, Vector3.right);

        }
        else if (axis == Axis.Y)
        {
            //t.y = wheel.eulerAngles.x; 
            this.transform.localRotation = Quaternion.AngleAxis(temp.y, Vector3.up);
        }
        else
        {
            // t.z = wheel.eulerAngles.x; 
            this.transform.localRotation = Quaternion.AngleAxis(temp.y, Vector3.forward);



        }

    }
}
