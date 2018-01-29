using System.Collections;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
	public GameObject Projectile;
	public float fireSpeed;
	public float fireRate;
	public float speed;
	public Transform Player;
	public Transform target1;
	public Vector3 target;

	private GameObject cloneProj;

	void Start()
	{
		target = target1.transform.position;

		transform.rotation = Player.transform.rotation;
	}

	void Update()
	{

		transform.rotation = Player.transform.rotation;
		if (Input.GetKey(KeyCode.Space) && Time.time > fireRate)
		{
			fireRate = Time.time + fireSpeed;
			cloneProj = (GameObject)Instantiate(Projectile, transform.position, transform.rotation);
			target = target1.transform.position;
		}

		var delta = speed * Time.deltaTime;
		cloneProj.transform.position = Vector3.MoveTowards(cloneProj.transform.position, target, delta);

		if (cloneProj.transform.position == target)
		{
			Destroy(cloneProj.gameObject);
		}
	}
}
