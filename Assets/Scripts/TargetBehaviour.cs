using UnityEngine;
using System.Collections;

public class TargetBehaviour : MonoBehaviour {

	ParticleSystem ps;
	public int sceneIndex;
	private string[] sceneNames;
	// Use this for initialization
	void Start () {
		ps = GetComponent<ParticleSystem>();
		sceneNames = new string[3];
		sceneNames[0] = "aimTestScene";
		sceneNames[1] = "bulletGravFieldTestScene";
		sceneNames[2] = "planetTestScene";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		ps.Play();
		StartCoroutine("LoadNextLevel");
	}

	IEnumerator LoadNextLevel()
	{
		yield return new WaitForSeconds(3.0f);

		Application.LoadLevel(sceneNames[sceneIndex + 1]);
	}
}
