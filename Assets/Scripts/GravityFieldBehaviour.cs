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

	void OnTriggerStay2D(Collider2D coll)
	{
        Vector2 force = Vector2.zero;
		bulletRb = coll.attachedRigidbody;
        switch (fieldDir)
        {
            case Direction.UP:
                force = new Vector2(0, gravStrength + Mathf.Abs(bulletRb.velocity.y));
                break;
            case Direction.DOWN:
                force = new Vector2(0, -(gravStrength + Mathf.Abs(bulletRb.velocity.y)));
                break;
        }

        bulletRb.AddForce(force);
	}
}
