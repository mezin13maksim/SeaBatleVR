using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompasLineScript : MonoBehaviour {
    Vector3 currentRotation;
    public Transform t;
    // Update is called once per frame
    void FixedUpdate () {

        this.transform.rotation = t.rotation;
        

    }
}
