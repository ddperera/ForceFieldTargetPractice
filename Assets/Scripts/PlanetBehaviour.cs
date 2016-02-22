using UnityEngine;
using System.Collections;

public class PlanetBehaviour : MonoBehaviour {

	private GameObject bullet;
	private Rigidbody2D bulletRb;
	public float gravConstant;

	// Use this for initialization
	void Start () {
		bullet = GameObject.FindGameObjectWithTag("Bullet");
		bulletRb = bullet.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D coll)
	{
		Vector2 vecToBullet = bullet.transform.position - gameObject.transform.position;

		bulletRb.AddForce(-vecToBullet.normalized * gravConstant / (vecToBullet.sqrMagnitude));
	}


}
