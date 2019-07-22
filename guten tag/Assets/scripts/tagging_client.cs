using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagging_client : MonoBehaviour {

	public float timer;
	public bool isTag = false;
	public GameObject plr;
	public tagging_control controller;
	
	// Use this for initialization
	void Start () {
		plr = GameObject.Find("player");
		controller = plr.GetComponent<tagging_control> ();
	}
	
	// Update is called once per frame
	/*void Update () {
		if (timer > 0) {
			timer -= Time.deltaTime;
			//ticks timer if timer has value
			//print (timer);
		}
	}
	*/
	void OnTriggerStay2D (Collider2D other)
	{
		if (isTag == true) {
			GameObject tar = other.gameObject;
			controller.Tag(gameObject,tar);
		}
	}
}