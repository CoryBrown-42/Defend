using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
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
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, 1));

		if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			Instantiate(bullet, firePoint.position, firePoint.rotation);
			source.PlayOneShot(GunSound);
		}
	}
}
