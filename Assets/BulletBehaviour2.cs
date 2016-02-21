using UnityEngine;
using System.Collections;

public class BulletBehaviour2 : MonoBehaviour {

	public Rigidbody2D rb;
	public float moveSpeed = 1.0f;

	// Use this for initialization
	void Start () {
		Vector2 vel;
		vel.x = moveSpeed;
		vel.y = 0.0f;

		rb.velocity = vel;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {

	}
}
