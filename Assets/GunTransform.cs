using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTransform : MonoBehaviour {

	public float curentXrotation = 0;
    public float curentYrotation = 0;
    public float speedXrotation = 1;
    public float speedYrotation = 1;
    public Transform gunTransform;
    public Transform platformTransform;
    public float maxXrotation = 90;
    public float minXrotation = 0;
    public bool isOn = false;

    float mapToAngle(Quaternion rotation)
    {
        float angle = rotation.eulerAngles.x;
        if (angle > 180)
        {
            angle -= 360;
        }
        return angle;
    }


    void Update() {

        if (isOn == true)
        {
            platformTransform.Rotate(0, curentYrotation * speedYrotation * Time.deltaTime, 0);

            if (curentXrotation < 0 && mapToAngle(gunTransform.localRotation) > minXrotation)
            {
                gunTransform.Rotate(curentXrotation * speedXrotation * Time.deltaTime, 0, 0);
            }
            else if (curentXrotation > 0 && mapToAngle(gunTransform.localRotation) < maxXrotation)
            {
                gunTransform.Rotate(curentXrotation * speedXrotation * Time.deltaTime, 0, 0);
            }
            
        }
    }


}
