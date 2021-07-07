using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class myNetwork : NetworkManager
{

    public Transform p1Spawn;
    public Transform p2Spawn;
    GameObject target;

    public override void OnServerAddPlayer(NetworkConnection conn)
        {
            // add player at correct spawn position
            Transform start = numPlayers == 0 ? p1Spawn : p2Spawn;
            GameObject player = Instantiate(playerPrefab, start.position, start.rotation);
            NetworkServer.AddPlayerForConnection(conn, player);

            // spawn ball if two players
            if (numPlayers == 2)
            {
                target = Instantiate(spawnPrefabs.Find(prefab => prefab.name == "Target"));
                NetworkServer.Spawn(target);
            }
        }

    public override void OnServerDisconnect(NetworkConnection conn)
        {
            // destroy ball
            if (target != null)
                NetworkServer.Destroy(target);

            // call base functionality (actually destroys the player)
            base.OnServerDisconnect(conn);
        }

    public override void OnStartServer()
    {
        Debug.Log("Server Started!");
    }

    public override void OnStopServer()
    {
        Debug.Log("Server Stopped!");
    }

    public override void OnClientConnect(NetworkConnection conn)
        {
            Debug.Log("Connected to Server!");
        }

    public override void OnClientDisconnect(NetworkConnection conn)
        {
            Debug.Log("Disconnected from Server!");
        }
}
