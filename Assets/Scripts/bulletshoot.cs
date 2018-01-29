using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bulletshoot : MonoBehaviour
{

	//public int pointValue = 5;
	public float speed = 15f;
	//public Rigidbody2D bullet;
	public int pointValue = 5;
	public int damage = 10;

	void Start()
	{
		fireShot();
	}

	void fireShot()
	{
		GetComponent<Rigidbody2D>().velocity = new Vector3(0, 1, 0) * speed * (Time.deltaTime * 2);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if ((col.gameObject.name == "Enemy") || (col.gameObject.name == "Enemy(Clone)"))
		{
			Destroy(col.gameObject);
			Game gameScript = FindObjectOfType<Game>();
			gameScript.AddScore(pointValue);
		}
		if ((col.gameObject.name == "HealthPickup") || (col.gameObject.name == "HealthPickup(Clone)"))
		{

			Game gameScript = FindObjectOfType<Game>();
			gameScript.minusHealth();
			gameScript.subHealth(damage);
		}

		if (col.gameObject)
		{
			Destroy(gameObject);
		}
	}
}