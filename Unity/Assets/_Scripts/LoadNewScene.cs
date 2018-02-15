using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNewScene : MonoBehaviour {

	public void LoadScene(int level)
	{
		Application.LoadLevel(level);
	}
}
