using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

	/*public Transform Player;
	public Transform enemy;
	private static bool IsAttacking = false;
	public Rigidbody2D Bullet;
	public Transform SpawnPoint;
	private Vector3 Distance;
	private float DistanceFrom;
	public float fireRate = 0.5f;
	public float nextFire = 0f;

	void Update()
	{
		Attacking();

		// Calculate the distance between the player  the enemy

		Distance = (enemy.position - Player.position);
		Distance.y = 0;
		DistanceFrom = Distance.magnitude;
		Distance /= DistanceFrom;

		// If the player is 20m away from the enemy, ATTACK!

		if (DistanceFrom < 20)
		{
			IsAttacking = true;
		}
		else
		{
			IsAttacking = false;
		}
	}

	void Attacking()
	{
		if (IsAttacking)
		{
			// The enemy isn't blind so it should face the player
			enemy.LookAt(Player);

			//Shoot

			if (Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;

				var Shoot = Instantiate(Bullet, SpawnPoint.position, SpawnPoint.rotation);
				Shoot.AddForce(SpawnPoint.forward * 5000);
			}
		}
	}*/

	public Rigidbody2D bullet;
	public Transform firePoint;
	public AudioClip GunSound;

	private AudioSource source;

	void Awake()
	{
		source = GetComponent<AudioSource>();
	}

	void Update()
	{
		{
			Instantiate(bullet, firePoint.position, firePoint.rotation);
			source.PlayOneShot(GunSound);
		}
	}
}
