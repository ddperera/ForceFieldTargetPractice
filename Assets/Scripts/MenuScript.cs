using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public void ClickButton(){
		Debug.Log ("Clicked");
		SceneManager.LoadScene ("aimTestScene");
	}
		
}
