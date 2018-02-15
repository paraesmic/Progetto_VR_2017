using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour {
	public int sceneToLoad;

	public void LoadScene()
	{	
		Application.LoadLevel (sceneToLoad);
	}
}
