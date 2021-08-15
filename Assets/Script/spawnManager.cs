using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
	public static spawnManager instance;

    public Transform[] spawnPoints;

    void Start() 
    {
        instance = this;
    }

}
