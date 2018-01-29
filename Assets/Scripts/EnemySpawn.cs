using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{
	public GameObject Enemy;
	public Transform[] spawnPoints;         // An array of the spawn points this Player can spawn from.
    public float SpawnRate = 2;

    //public float deduction = 0.1f;

    //public IEnumerator SpawnIncrease;
    
   void Awake()
    {
        InvokeRepeating("Spawn", 1, 2);
        //SpawnIncrease = IncreaseSpawn();
        //ChangeRate();
        //StopAllCoroutines();
    }
    /*public void ChangeRate()
    {
        StartCoroutine(SpawnIncrease);
    }*/


    void Spawn()
	{
		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);
		// Create an instance of the Enemy prefab at the randomly selected spawn point's position and rotation.
		Instantiate(Enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}

    /*public IEnumerator IncreaseSpawn()
    {
        SpawnRate -= deduction;
        yield return new WaitForSeconds(10);
    }*/
}
