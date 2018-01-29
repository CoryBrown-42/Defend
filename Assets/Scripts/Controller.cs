using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	public float speed;
	//public float Time;

	private Rigidbody2D rb2d;
	public int damage = -5;
	public int healing = 5;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>(); ;
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.AddForce(movement * speed);

		if (!Input.GetKeyDown(KeyCode.D) ||
			!Input.GetKeyDown(KeyCode.A) ||
			!Input.GetKeyDown(KeyCode.W) ||
			!Input.GetKeyDown(KeyCode.S) ||
			!Input.GetKeyDown(KeyCode.LeftArrow) ||
			!Input.GetKeyDown(KeyCode.UpArrow) ||
			!Input.GetKeyDown(KeyCode.DownArrow) ||
			!Input.GetKeyDown(KeyCode.RightArrow))
		{
			rb2d.velocity = new Vector3(moveHorizontal * speed, rb2d.velocity.y, 0);
		}

	}
	public void OnCollisionEnter2D(Collision2D col)
	{
		if ((col.gameObject.name == "Enemy") || (col.gameObject.name == "Enemy(Clone)") || (col.gameObject.name == "bullet1") || (col.gameObject.name == "bullet1(Clone)"))
		{
			Game gameScript = FindObjectOfType<Game>();
			gameScript.minusHealth();
			gameScript.subHealth(damage);

		}
		if ((col.gameObject.name == "HealthPickup") || (col.gameObject.name == "HealthPickup(Clone)"))
		{
			Game gameScript = FindObjectOfType<Game>();
			gameScript.plusHealth();
			gameScript.AddHealth(healing);

		}
	}
}