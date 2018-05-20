using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnHit : MonoBehaviour {

	public AudioClip sound;

	void Start ()   
	{
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = sound;
	}        

	void OnCollisionEnter ()  //Plays Sound Whenever collision detected
	{
		GetComponent<AudioSource> ().Play ();
	}

}
