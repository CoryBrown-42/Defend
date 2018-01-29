using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
	public float maxSpeed = 25f;
	public Rigidbody2D bullet;

	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Vector3 mousePos = Input.mousePosition;
			Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
			mousePos.x = mousePos.x - objectPos.x;
			mousePos.y = mousePos.y - objectPos.y;
			float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
			transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
			Rigidbody2D bulletInstance = Instantiate(bullet, transform.position, Quaternion.Euler(new Vector3(0, 0, 1))) as Rigidbody2D;
			bulletInstance.velocity = transform.forward * maxSpeed;
			GetComponent<Rigidbody2D>().velocity = Quaternion.AngleAxis(angle, Vector3.forward) * new Vector3(1, 0, 0) * maxSpeed * Time.deltaTime;


			Physics2D.IgnoreCollision(bulletInstance.GetComponent<Collider2D>(), GetComponent<Collider2D>());
		}
	}
}
