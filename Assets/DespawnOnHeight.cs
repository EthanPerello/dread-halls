using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DespawnOnHeight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= -5) {
            GameObject.Destroy(GameObject.Find("WhisperSource"));
            LevelCounter.mazeNumber = 0;
			SceneManager.LoadScene("GameOver");
		}
	}
}