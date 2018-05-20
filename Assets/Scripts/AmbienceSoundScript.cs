using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceSoundScript : MonoBehaviour {

	public AudioClip sound;

	void Start ()   
	{
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = sound;
		GetComponent<AudioSource> ().Play ();
	}
}
