using UnityEngine;
using System.Collections;

public class depth : MonoBehaviour {

	private float Yposition;
	private float Xposition;

	void Update () {
	
		Xposition = transform.position.x;
		Yposition = transform.position.y;
		transform.position = new Vector3 (Xposition, Yposition, Yposition);

	}
}
