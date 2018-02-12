using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickScript : MonoBehaviour {

    public GunTransform gunTransform;

    public bool track = false;

    float mapToAngleX(Quaternion rotation)
    {
        float angle = rotation.eulerAngles.x;
        if (angle > 180)
        {
            angle -= 360;
        }
        return angle;
    }

    float mapToAngleZ(Quaternion rotation)
    {
        float angle = rotation.eulerAngles.z;
        if (angle > 180)
        {
            angle -= 360;
        }
        return angle;
    }

    float mod(float f)
    {
        if (f < 0)
            return -f;
        else
            return f;
    }

    public void setTrack(bool set)
    {
        track = set;

    }

	void Update () {

        if (track)
        {
            gunTransform.isOn = true;

            if (mapToAngleX(this.transform.localRotation) < 90 && mapToAngleX(this.transform.localRotation) > -90 &&
                mapToAngleZ(this.transform.localRotation) > -90 && mapToAngleZ(this.transform.localRotation) < 90)
            {
                if (mod(mapToAngleX(this.transform.localRotation)) > mod(mapToAngleZ(this.transform.localRotation)))
                {
                    gunTransform.curentXrotation = mapToAngleX(this.transform.localRotation);
                    gunTransform.curentYrotation = 0;
                }
                else
                {
                    gunTransform.curentXrotation = 0;
                    gunTransform.curentYrotation = mapToAngleZ(this.transform.localRotation);

                }
                
            }

        }
        else
        { gunTransform.isOn = false; }
    }
}
