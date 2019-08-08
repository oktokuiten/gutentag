using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagging_control : MonoBehaviour {

	public float timer;
	public float stimer = 1.0f;
	public int score = 0;
	[Tooltip("Controls who starts the round as tagged. 0 is random, 1 is player, above is AI.")]
	public int InitTag = 0;
	GameObject[] tagList = null;
	GameObject tagObj;
	GameObject player;
	tagging_client tar;
	int iTagged;
	// Use this for initialization
	void Start () {
		// Create array of taggable entities if it doesn't exist
		if (tagList == null){
			tagList = GameObject.FindGameObjectsWithTag("Tagging");
		}
		// retrieve player from array
		for (int i = 0; i < tagList.Length; i++) {
			if (tagList[i].name == "player") {
				player = tagList[i];
			}
		}
		iTagged = Random.Range(0,tagList.Length);
		tagObj = tagList[iTagged];
		if (InitTag == 1) { // char init tagger 
			tagObj = player;
		}
		tar = tagObj.GetComponent<tagging_client> ();
		tar.isTag = true;
		tagObj.GetComponent<SpriteRenderer>().color = Color.red;
	}
	
	
	// Update is called once per frame
	void Update () {
		if (timer > 0) {
			timer -= Time.deltaTime;
			//ticks timer if timer has value
			//print (timer);
		}
		// Give score
		if (stimer <= 0) {
			if (tagObj != player) {
				score++;
				print("Score; " + score);
			}
			stimer = 1.0f;
		}
		stimer -= Time.deltaTime;
	}
	void OnGUI () {
		GUI.Label (new Rect (20,20,220,120), "Score: " + score);
    }
	// tag function called by tagger collision
	public void Tag (GameObject tagger, GameObject taggee)
	{
		if (timer > 0) return;
		timer = 2.0f;
		tagger.GetComponent<tagging_client>().isTag = false;
		taggee.GetComponent<tagging_client>().isTag = true;
		tagger.GetComponent<SpriteRenderer>().color = Color.white;
		taggee.GetComponent<SpriteRenderer>().color = Color.red;
		tagObj = taggee;
		print(tagger.name + " tagged " + taggee.name);
	}
}