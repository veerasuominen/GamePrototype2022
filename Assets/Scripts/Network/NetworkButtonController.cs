using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using Unity.Networking;
using Unity.Multiplayer;

public class NetworkButtonController : MonoBehaviour
{
    [SerializeField] private GameObject player2;
#if UNITY_SERVER && !UNITY_EDITOR
    public void Start()
    {
        NetworkManager.Singleton.StartServer();
        
    }

#else
    public void StartHost()
    {
        NetworkManager.Singleton.StartHost();
        this.gameObject.GetComponent<NetworkManager>().NetworkConfig.PlayerPrefab = player2;
    }

    public void StartClient()
    {
        NetworkManager.Singleton.StartClient();
    }

    public void StartServer()
    {
        NetworkManager.Singleton.StartServer();
    }

    public void Disconnect()
    {
        NetworkManager.Singleton.Shutdown();
    }

#endif
}
