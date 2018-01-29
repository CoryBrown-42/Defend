using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Bullet : MonoBehaviour
{
	public float maxSpeed = 25f;
	public Rigidbody bullet;

	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Rigidbody bulletInstance = Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0, 0, 1))) as Rigidbody;
			bulletInstance.velocity = transform.forward * maxSpeed;

			Physics.IgnoreCollision(bulletInstance.GetComponent<Collider>(), GetComponent<Collider>());
		}
		//this is a push.........
	}
}
