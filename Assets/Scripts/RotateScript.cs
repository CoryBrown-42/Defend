using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{

	public int spin;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		transform.Rotate(Vector3.down * spin * Time.deltaTime);
	}
}