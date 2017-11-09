using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
	private bool didPlayed;
	public AudioClip soundClip;
	public float volume;
	private AudioSource audio;

	 void Start()
	 {
		 audio = gameObject.AddComponent<AudioSource>();
		 audio.clip = soundClip;
		 audio.volume = volume;
	 }

	void OnTriggerEnter(Collider other)
	{
//		Debug.Log("SoundClip="+soundClip==null);
//		Debug.Log("audioSource="+audio==null);
//		Debug.Log("volume="+volume==null);
//		Debug.Log("didPlayed="+didPlayed==null);
		if (didPlayed) return;
		audio.PlayOneShot(soundClip);
		didPlayed = true;
	}
}
