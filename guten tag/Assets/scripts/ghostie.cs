/*using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ghostie : MonoBehaviour {

//	public string equipitemname = "empty";
	//public string itemname = "empty";
	public string speech = "empty";
	public invscroll invsiz;
	public speechtext say;
	float timer = 1f;
	public float timer2 = 10f;

	void Start(){
	
	}

	void Update () {
		if (timer > 0) {
			timer -= Time.deltaTime * timer2;
//						print (timer);
		}
	}
	
	void OnTriggerStay2D (Collider2D other)
	{
		GameObject gObj = other.gameObject;


		if (gObj.CompareTag("Player") && Input.GetButtonDown ("Action") && timer <= 0)
		{
			say.speechhh(speech);
			timer = 1;
			

		}
	}
}*/