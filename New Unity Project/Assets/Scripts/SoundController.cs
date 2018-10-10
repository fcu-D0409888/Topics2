using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]
public class SoundController : MonoBehaviour {

	public AudioClip[] Sounds;

	public void PlaySound(int index) {
		AudioSource asc = (AudioSource)this.GetComponent(typeof(AudioSource));
		asc.clip = Sounds[index];
		asc.Play();
	}
}
