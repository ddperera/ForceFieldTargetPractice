using UnityEngine;
using System.Collections;

public class GravityFieldBehaviour : MonoBehaviour {

	public Rigidbody2D bulletRb;
	public float gravStrength;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		Debug.Log("works");
		Vector2 vel;
		vel.x = bulletRb.velocity.x;
		vel.y = bulletRb.velocity.y;
		vel.y = vel.y - gravStrength;
		bulletRb.velocity = vel;
	}
}
