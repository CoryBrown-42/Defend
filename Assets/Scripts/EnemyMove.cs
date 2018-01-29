using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
	public int speed = -6;
	void Update()
	{
		transform.Translate(transform.up * -6 * Time.deltaTime);
	}
}
