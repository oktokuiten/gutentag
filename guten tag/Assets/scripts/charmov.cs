using UnityEngine;
using System.Collections;

public class charmov : MonoBehaviour {

	public float fast = 5f;


	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)/* && !Input.GetKey (KeyCode.UpArrow) && !Input.GetKey (KeyCode.DownArrow)*/) {
			transform.Translate (Vector2.right * fast * Time.deltaTime);
		}
		
		if (Input.GetKey (KeyCode.LeftArrow)/* && !Input.GetKey (KeyCode.UpArrow) && !Input.GetKey (KeyCode.DownArrow)*/) {
			transform.Translate (Vector2.left * fast * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.UpArrow) && !Input.GetKey (KeyCode.LeftArrow) && !Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.up * fast * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.DownArrow) && !Input.GetKey (KeyCode.LeftArrow) && !Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector2.down * fast * Time.deltaTime);
		}
	}
}
