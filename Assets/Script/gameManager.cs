using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class gameManager : MonoBehaviourPunCallbacks
{
    public override void OnJoinedRoom()
    {
        GameObject obj = PhotonNetwork.Instantiate("Gaco_1", new Vector3(-1, 1, -8), Quaternion.identity);
    }
}
