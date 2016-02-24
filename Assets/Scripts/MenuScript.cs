using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public void ClickButton(){
		SceneManager.LoadScene ("aimTestScene", LoadSceneMode.Single);
	}
		
}
