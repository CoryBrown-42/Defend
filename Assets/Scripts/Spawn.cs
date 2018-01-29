using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
	public GameObject spawnPlayer;
	public GameObject spawn;

	void Awake()
	{
		Invoke("Spawn", 1);
		Instantiate(spawnPlayer, spawn.transform.position, spawn.transform.rotation);
	}
}