﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {

	public string scene;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Submit") == 1) {
			if (scene == "Play") {
				SceneManager.LoadScene("Play");
			}
			if (scene == "Title") {
				SceneManager.LoadScene("Title");
			}
		}
	}
}
