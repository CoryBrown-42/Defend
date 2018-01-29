using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameDipper : MonoBehaviour
{
	public int damage = 5;
	public int healing = 5;



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
