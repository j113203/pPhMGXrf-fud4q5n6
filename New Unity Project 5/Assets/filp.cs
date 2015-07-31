using UnityEngine;
using System.Collections;

public class filp : MonoBehaviour {
	[HideInInspector]
	public bool facingRight = true;
	[HideInInspector]

	private Animator anim;
	


	// Use this for initialization
	void Awake () {
		anim = GetComponent<Animator>();
	}

	void FixedUpdate () {
		float h = Input.GetAxis ("Horizontal");

		if (h > 0 && !facingRight)
			flip ();
		else if (h < 0 && facingRight)
			flip ();


		if (Input.GetKeyDown("up")) {
			anim.Play ("run");

		} 

		else if (Input.GetKeyUp("up")) {
			anim.Play ("player");
		} 
/////////////////////////////////////////////////////////////////////////
		if (Input.GetKeyDown("down")) {
			anim.Play ("run");

		} 

		else if(Input.GetKeyUp("down")) {
			anim.Play ("player");
		} 
/////////////////////////////////////////////////////////////////////////
		if (Input.GetKeyDown("right")) {
			anim.Play ("run");

		} 

		else if (Input.GetKeyUp("right")) {
			anim.Play ("player");
		} 
//////////////////////////////////////////////////////////////////////////
		if (Input.GetKeyDown("left")) {
			anim.Play ("run");

		} 

		else if(Input.GetKeyUp("left")) {
			anim.Play ("player");
		} 
///////////////////////////////////////////////////////////////////////
	}

	void flip(){
		
		facingRight = !facingRight;
		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		
	}

}
