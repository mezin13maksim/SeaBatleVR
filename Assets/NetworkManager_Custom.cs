using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;
using System;

public class NetworkManager_Custom : NetworkManager
{

    public void StartupHost()
    {
        SetPort();
        NetworkManager.singleton.StartHost();
    }

    public void JoinGame()
    {
        if (Network.Connect("localhost") == NetworkConnectionError.NoError)
        {
            print("Client");
            SetIPAddress();
            SetPort();
            NetworkManager.singleton.StartClient();
        }
        else
        {
            print("Host");
            StartupHost();
        }

    }

    public void QuitGame()
    {
        try
        {
            NetworkManager.singleton.StopClient();
        }
        catch (Exception e)
        {
            NetworkManager.singleton.StopHost();
        }
    }

    void SetIPAddress()
    {
        string ipAddress = GameObject.Find("InputFieldIPAddress").transform.Find("Text").GetComponent<Text>().text;
        NetworkManager.singleton.networkAddress = ipAddress;
    }

    void SetPort()
    {
        NetworkManager.singleton.networkPort = 7777;
    }
}