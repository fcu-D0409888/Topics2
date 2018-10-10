using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
	public static int points = 0;
	public float CountDownTime = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CountDownTime > 0) {
			CountDownTime -= Time.deltaTime;
		}
	}
	 void OnGUI(){
		GUI.Label (new Rect (10, 10, 100, 50), "Score : " + points);
		if (CountDownTime > 0) {
			GUI.color = Color.black;
			GUI.Label (new Rect (10, 30, 100, 50), "倒數計時: " + (int)CountDownTime);
		} else {
			GUI.color = Color.red;
			GUI.Label (new Rect (10, 30, 100, 50), "時間到了!");
			SceneManager.LoadScene ("24 - Surface Shader Example");
		}
	}
}
