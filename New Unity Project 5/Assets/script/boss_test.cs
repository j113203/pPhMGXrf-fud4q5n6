using UnityEngine;
using System.Collections;

public class boss_test : MonoBehaviour {

	public bool facingRight = true;

	private Animator anim;

	public float gethit = 0.5F;
	private float nextgethit = 0.0F;


	bool test = false;


	void Awake () {
		anim = GetComponent<Animator>();
		anim.Play ("stay");
	}

	public void getMessage(){
		anim.Play ("gethit");
		test = true;
	}


	void Update(){
		if (test = true && Time.time > nextgethit) {
			nextgethit = Time.time + gethit;
			anim.Play("stay");
		}
	}



	void FixedUpdate () {
		/*float h = Input.GetAxis ("Horizontal");
		
		if (h > 0 && !facingRight)
			flip ();
		else if (h < 0 && facingRight)
			flip ();*/
	}

	
	void flip(){
		
		/*facingRight = !facingRight;
		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;*/
		
	}
}