using UnityEngine;
using System.Collections;

public class TargetBehaviour : MonoBehaviour {

	ParticleSystem ps;
	public int sceneIndex;
	private string[] sceneNames;
	// Use this for initialization
	void Start () {
		ps = GetComponent<ParticleSystem>();
		if (ps.isPlaying) {
			ps.Stop ();
		}
		sceneNames = new string[4];
		sceneNames[0] = "aimTestScene";
		sceneNames[1] = "bulletGravFieldTestScene";
		sceneNames[2] = "planetTestScene";
		sceneNames[3] = "endScene";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (!ps.isPlaying) {
			ps.Play ();
		}
		Debug.Log ("Playing at collision: " + ps.isPlaying);
		StartCoroutine("LoadNextLevel");
	}

	IEnumerator LoadNextLevel()
	{
		yield return new WaitForSeconds(3.0f);
		Application.LoadLevel(sceneNames[sceneIndex + 1]);

	}
}
