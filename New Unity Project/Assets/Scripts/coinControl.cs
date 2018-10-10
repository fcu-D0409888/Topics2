using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 1, 0);
		//transform.Rotate (new Vector3(0, 0, 90)*Time.deltaTime);
	}
	private void OnTriggerEnter(Collider other)
	{
		if (other.name == "Player") {
			PlayerScript.points++;
			((SoundController)GameObject.FindObjectOfType (typeof(SoundController))).PlaySound (0);
			this.gameObject.SetActive (false);
			//Destroy (gameObject);
		}
	}
}
