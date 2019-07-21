using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

	public GameObject player;
	public float dist;
	public int camrange = 1;
	public float fastcam = 7f;
	private Vector3 target;




	void FixedUpdate () {

		float dist = Vector2.Distance (gameObject.transform.position, player.transform.position);

		target = player.transform.position;
		target.z = player.transform.position.z - 10;

		if (dist > camrange) {
			transform.position = Vector3.MoveTowards (transform.position, target, (fastcam * dist - 2f) * Time.deltaTime);
		}
		/*if (dist > camrange) {
			gameObject.transform.parent = player.transform;
		} else {
			gameObject.transform.parent = null;
		}*/

	}
	
}
