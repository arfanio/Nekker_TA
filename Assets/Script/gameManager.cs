using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class gameManager : MonoBehaviourPunCallbacks, IPunObservable
{
    GameObject obj;
    // public GameObject target;

    public override void OnJoinedRoom()
    {
        obj = PhotonNetwork.Instantiate("Gaco_1", new Vector3(-1, 1, -8), Quaternion.identity);
        // if  (Launcher.Player == 2){
        //     target.gameObject.SetActive(true);
        // }
        
        
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            // We own this player: send the others our data
            stream.SendNext(obj);
        }
        else
        {
            // Network player, receive data
            this.obj = (GameObject)stream.ReceiveNext();
        }
    }

}
