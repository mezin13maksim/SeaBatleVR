using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NewBehaviourScript : NetworkBehaviour {

	// Use this for initialization
	void Start () {
        GameObject vrc = GameObject.Find("VRController");
        vrc.transform.position = transform.position;
        vrc.transform.SetParent(this.transform);
        this.transform.SetParent(GameObject.Find("Ship").transform);
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
            return;
	}
}
