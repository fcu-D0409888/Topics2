using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class startScript : MonoBehaviour {
	public GameObject a;
	public GameObject text;
	public GameObject text1;
	// Use this for initialization
	void Start () {
		
		int point = PlayerScript.points;
		if (point != 0) {
			text.SetActive (true);
			text1.SetActive (true);
			GameObject.Find ("ScoreNum").GetComponent<Text> ().text = point.ToString ();

		} else {
			text.SetActive (false);
			text1.SetActive (false);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnBtn(){
		Debug.Log ("點擊按鈕");
		SceneManager.LoadScene ("demo_scene_low");
		//Application.LoadLevel ("SampleScene");
		a.SetActive (false);
	}
}
