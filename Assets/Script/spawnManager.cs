using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
	public static spawnManager Instance;

	Spawnpoint[] spawnpoints;

	void Awake()
	{
		Instance = this;
		spawnpoints = GetComponentsInChildren<Spawnpoint>();
	}

	public Transform GetSpawnpoint()
	{
		return spawnpoints[Random.Range(0, spawnpoints.Length)].transform;
	}
}
