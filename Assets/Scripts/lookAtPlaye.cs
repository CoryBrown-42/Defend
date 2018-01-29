using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtPlaye : MonoBehaviour
{
	public Transform target;
	private Vector3 diff;
	private float atan2;

	void Update()
	{
		diff = (target.position - transform.position);
		atan2 = Mathf.Atan2(diff.y, diff.x);
		transform.rotation = Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg);
	}
}

