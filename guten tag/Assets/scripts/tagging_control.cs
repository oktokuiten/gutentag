using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagging_control : MonoBehaviour {

	public float timer;
	[Tooltip("Controls who starts the round as tagged. 0 is random, 1 is player, above is AI.")]
	public int InitTag = 0;
	GameObject[] tagList = null;
	tagging_client ptar;
	// Use this for initialization
	void Start () {
		// Create array of taggable entities if it doesn't exist
		if (tagList == null){
			tagList = GameObject.FindGameObjectsWithTag("Tagging");
		}
		// retrieve player from array
		for (int i = 0; i < tagList.Length; i++) {
			if (tagList[i].name == "player") {
				GameObject player = tagList[i];
				ptar = player.GetComponent<tagging_client> ();
				break;
			}
		}
		if (InitTag == 0) // random init tagger
		{
			int iTagged = Random.Range(0,tagList.Length);
			tagging_client tar = tagList[iTagged].GetComponent<tagging_client> ();
			tar.isTag = true;
		}
		else if (InitTag == 1) // char init tagger
			ptar.isTag = true;
		else // enemy init tagger
		{
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		if (timer > 0) {
			timer -= Time.deltaTime;
			//ticks timer if timer has value
			//print (timer);
		}

	}
	// tag function called by tagger collision
	public void Tag (GameObject tagger, GameObject taggee)
	{
		if (timer > 0) return;
		timer = 2.0f;
		tagger.GetComponent<tagging_client>().isTag = false;
		taggee.GetComponent<tagging_client>().isTag = true;
		print(tagger.name + " tagged " + taggee.name);
	}
}