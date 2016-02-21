using UnityEngine;
using System.Collections;

public class GF1B : MonoBehaviour {

	public Rigidbody2D bulletRb;
	public float gravStrength; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll) {
		
//		if (coll.gameObject.tag == "Bullet") {
//		Debug.Log ("works");
		Vector2 vel;
		vel.x = bulletRb.velocity.x;
		vel.y = bulletRb.velocity.y;
		vel.y = vel.y - gravStrength;
		Debug.Log (vel);
		bulletRb.velocity = vel;
//		}
	}
}
