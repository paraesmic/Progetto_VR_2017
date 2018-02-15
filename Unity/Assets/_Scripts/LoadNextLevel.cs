using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour {

	public GameManager GameManager;

	public void LoadScene(int level)
	{	
		Application.LoadLevel(level);
	}
}
