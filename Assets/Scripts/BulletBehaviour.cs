using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BulletBehaviour : MonoBehaviour
{

    public Rigidbody2D rb;
    public float moveSpeed = 1.0f;
    public enum State { AIM, FIRED };
    public State curState = State.AIM;
	private Vector2 initialPos;
	private TrailRenderer tr;

    // Use this for initialization
    void Start()
    {
		initialPos = transform.position;
		curState = State.AIM;
    }

    // Update is called once per frame
    void Update()
    {
		
    }

    void FixedUpdate()
    {
        switch (curState)
        {
            case State.AIM:
                if (Input.GetAxisRaw("Vertical") < 0)
                {
                    Vector2 vel;
                    vel.x = 0.0f;
                    vel.y = -moveSpeed / 2.0f;

                    rb.velocity = vel;
                }
                else if (Input.GetAxisRaw("Vertical") > 0)
                {
                    Vector2 vel;
                    vel.x = 0.0f;
                    vel.y = moveSpeed / 2.0f;

                    rb.velocity = vel;
                }
                else
                {
                    Vector2 vel;
                    vel.x = 0.0f;
                    vel.y = 0.0f;

                    rb.velocity = vel;
                }

                if (Input.GetAxisRaw("Fire1") > 0)
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
		tr = gameObject.AddComponent<TrailRenderer>();
		tr.startWidth = 0.1f;
		tr.endWidth = 0.1f;
		tr.autodestruct = true;
		tr.time = 100.0f;
        Vector2 vel;
        vel.x = moveSpeed;
        vel.y = 0.0f;

        rb.velocity = vel;
    }
}
