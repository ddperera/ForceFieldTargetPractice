using UnityEngine;
using System.Collections;

public class GravityFieldBehaviour : MonoBehaviour {

	private Rigidbody2D bulletRb;
	public float gravStrength;
	public enum Direction {UP, DOWN};
	public Direction fieldDir;
	// Use this for initialization
	void Start () {
		bulletRb = GameObject.FindGameObjectWithTag("Bullet").GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		Vector2 vel;
		vel.x = bulletRb.velocity.x;
		vel.y = bulletRb.velocity.y;
		switch(fieldDir)
		{
		case Direction.DOWN:
			vel.y = vel.y - gravStrength;
			break;
		case Direction.UP:
			vel.y = vel.y + gravStrength;
			break;
		}
		bulletRb.velocity = vel;
	}
}
