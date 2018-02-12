using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour {

    GameObject nm;

    // Use this for initialization
    void Start () {
        nm = GameObject.Find("Networking Manager");
        nm.GetComponent<NetworkManager_Custom>().JoinGame();
	}

    void OnApplicationQuit()
    {
        nm.GetComponent<NetworkManager_Custom>().QuitGame();
        print("njk");
    }
}
