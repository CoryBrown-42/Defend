using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enShoot : MonoBehaviour 
{
	public Transform Target;
	public float speed;
	public AudioClip GunSound;

	private GameObject Enemy;
	private GameObject Player;
	private float Range;
	private AudioSource source;

	void Awake()
	{
		source = GetComponent<AudioSource>();
	}

	void Start()
	{
		Enemy = GameObject.FindGameObjectWithTag ("Enemy");
		Player = GameObject.FindGameObjectWithTag ("Player");
	}

	void Update()
	{
		Vector2 velocity = new Vector2 ((transform.position.x - Player.transform.position.x) * speed, (transform.position.y - Player.transform.position.y) * speed);
		GetComponent<Rigidbody2D> ().velocity = -velocity;
	}

}