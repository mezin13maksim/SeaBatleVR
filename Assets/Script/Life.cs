﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {

    public int life;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (life <= 0)        {
            Destroy(this.gameObject);
        }
		
	}
}
