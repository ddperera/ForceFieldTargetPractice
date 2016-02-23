using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject bulletPrefab;
	GameObject curBullet;
	BulletBehaviour curBulletScript;
	Vector3 bulletStartPos;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(transform.gameObject);
		bulletStartPos = new Vector3(-5.0f, 3.5f, 0.0f);
		OnLevelWasLoaded(0);
	}

	void OnLevelWasLoaded(int levelID)
	{
		curBullet = (GameObject)Instantiate(bulletPrefab, bulletStartPos, Quaternion.identity);
		curBulletScript = curBullet.GetComponent<BulletBehaviour>();
		curBulletScript.curState = BulletBehaviour.State.AIM;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Submit") > 0)
		{
			if(curBulletScript.curState == BulletBehaviour.State.FIRED)
			{
				curBullet = (GameObject)Instantiate(bulletPrefab, bulletStartPos, Quaternion.identity);
				curBulletScript = curBullet.GetComponent<BulletBehaviour>();
				curBulletScript.curState = BulletBehaviour.State.AIM;
			}

		}
	}


}
