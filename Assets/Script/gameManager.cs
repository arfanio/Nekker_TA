using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class gameManager : MonoBehaviourPunCallbacks, IPunObservable
{
    GameObject obj;

    public static int update_pointGameManager = 0;

    void Start ()
    {
        update_pointGameManager = PlayerPrefs.GetInt ("id_gaco");
    }

    public override void OnJoinedRoom()
    {
         if (update_pointGameManager == 0){
            Debug.Log(update_pointGameManager);
            obj = PhotonNetwork.Instantiate("Gaco_1", spawnManager.instance.spawnPoints[update_pointGameManager].position, Quaternion.identity);
        }

        if (update_pointGameManager == 1){
            Debug.Log(update_pointGameManager);
            obj = PhotonNetwork.Instantiate("Gaco_1", new Vector3(-1, 1, -8), Quaternion.identity);
        }

        if (update_pointGameManager == 2){
            Debug.Log(update_pointGameManager);
            obj = PhotonNetwork.Instantiate("Gaco_2", new Vector3(-1, 1, -8), Quaternion.identity);
        }
         
        if (update_pointGameManager == 3){
            Debug.Log(update_pointGameManager);
            obj = PhotonNetwork.Instantiate("Gaco_3", new Vector3(-1, 1, -8), Quaternion.identity);
        }

        if (update_pointGameManager == 4){
            Debug.Log(update_pointGameManager);
            obj = PhotonNetwork.Instantiate("Gaco_4", new Vector3(-1, 1, -8), Quaternion.identity);
        }
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
