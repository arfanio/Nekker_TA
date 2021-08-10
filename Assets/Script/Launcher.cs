using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Launcher : MonoBehaviourPunCallbacks
{
    
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Connecting to Master");
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
        RoomOptions roomOptions = new RoomOptions() { IsVisible = true, MaxPlayers = 2 };
        PhotonNetwork.JoinOrCreateRoom("room", roomOptions, TypedLobby.Default);
        Debug.Log("Connected to Master");
        
    }
    
    void OnDisconnectedFromPhoton()
    {
        Debug.Log("Terputus dengan Photon");
    }

     public void MeninggalkanRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
