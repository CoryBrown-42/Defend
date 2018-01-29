using UnityEngine;
using System.Collections;


public class Destroy : MonoBehaviour
{
	void OnTrigger2D(Collider other)
	{
		if (other.gameObject.tag == ("Enemy") || other.gameObject.tag == ("KillWall"))
		{
			Destroy(gameObject);
		}
	}

}