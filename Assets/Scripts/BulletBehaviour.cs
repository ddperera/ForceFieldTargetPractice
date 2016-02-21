using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {

	public Rigidbody2D rb;
	public float moveSpeed = 1.0f;
	private enum State{AIM, FIRED};
	private State curState = State.AIM;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() 
	{
		switch(curState)
		{
		case State.AIM:
			if(Input.GetAxisRaw("Vertical") < 0)
			{
				Vector2 vel;
				vel.x = 0.0f;
				vel.y = -moveSpeed/2.0f;

				rb.velocity = vel;
			}
			else if (Input.GetAxisRaw("Vertical") > 0)
			{
				Vector2 vel;
				vel.x = 0.0f;
				vel.y = moveSpeed/2.0f;

				rb.velocity = vel;
			}
			else
			{
				Vector2 vel;
				vel.x = 0.0f;
				vel.y = 0.0f;

				rb.velocity = vel;
			}

			if(Input.GetAxisRaw("Fire1") > 0)
			{
				Fire();
			}
			break;
		case State.FIRED:
			break;
		}
	}

	void Fire()
	{
		curState = State.FIRED;
		Vector2 vel;
		vel.x = moveSpeed;
		vel.y = 0.0f;

		rb.velocity = vel;
	}
}
