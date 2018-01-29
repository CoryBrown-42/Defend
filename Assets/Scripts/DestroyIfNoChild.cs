using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfNoChild : MonoBehaviour
{
	public float time = 5f;
	// Use this for initialization
	void Start()
	{
		StartCoroutine(TimedDestroy());
	}

	// Update is called once per frame
	void Update()
	{

	}

	public IEnumerator TimedDestroy()
	{

		yield return new WaitForSeconds(time);
		Destroy(gameObject);

	}
}
