using UnityEngine;
using System.Collections;

public class PlanetField : MonoBehaviour {

	private Rigidbody2D bulletRb;

	// Use this for initialization
	void Start () {
		bulletRb = GameObject.FindGameObjectWithTag("Bullet").GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll)
	{
		
	}


}
