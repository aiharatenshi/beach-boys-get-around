using UnityEngine;
using System.Collections;

public class ExitTrigger : MonoBehaviour {
	public AudioSource otherObject;
	public AudioSource beachboys;
	// Use this for initialization
	void Start () {
	beachboys.audio.Play ();
	}
	
	// Update is called once per frame
	void Update () {
	//float timetext = Time.time;
		//guiText.text = timetext.ToString();
	}
	
	void OnTriggerExit() {
		guiText.text = "Sorry! You Fell off!";
		beachboys.audio.Stop();
		otherObject.audio.Play();
	}
		
}
