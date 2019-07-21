/*using UnityEngine;
using System.Collections;

public class charmov22 : MonoBehaviour {

	public float fast2 = 4f;
	private Rigidbody2D rgbd;
	public GameObject invo;
	public GameObject cdbox;
	bool facingRight = true;
	Animator anim;

	void Start(){
		rgbd = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate () {
		 {
			float hor = Input.GetAxis ("Horizontal");
			float ver = Input.GetAxis ("Vertical");

			anim.SetFloat ("sped", Mathf.Abs (hor));
			anim.SetFloat ("sped2", ver);

			if (hor > 0 && !facingRight){
				Flip ();
			
			}else if (hor < 0 && facingRight){
				Flip ();

			}else if (ver != 0 && !facingRight && hor >= 0){
				Flip ();
			}
//			if (hor != 0) {
//				ver = 0;
//			}

			if (hor != 0 && ver != 0) {
				fast2 = 3f;
			}else{
				fast2 =4f;
			}

			rgbd.velocity = new Vector2 (hor * fast2, ver * fast2);

		} 

	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
*/