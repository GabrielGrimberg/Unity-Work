﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour 
{
	public void LoadLevel(string name)
	{
		Debug.Log("Level Load Requested");
		Application.LoadLevel(name);
	}

	public void QuitRequest()
	{
		Debug.Log("Quit Is Pressed");
		Application.Quit();
	}
		

}
