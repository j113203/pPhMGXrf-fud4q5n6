using UnityEngine;
using System.Collections;

public class filp : MonoBehaviour {
	[HideInInspector]
	public bool facingRight = true;
	[HideInInspector]
	
	private Animator anim;
	public GameObject boss;
	public float MoveSpeed;
	
	bool test = false;
	
	void Awake () {
		anim = GetComponent<Animator>();
		anim.Play ("player");
		
	}
	
	void Update() {
		/////////////////////////////MOVE/////////////////////////////////////////////////////////////
		if (Input.GetKey ("up")) {
			transform.Translate (0, MoveSpeed * Time.deltaTime, 0);
			anim.Play ("run");
		} else if (Input.GetKeyUp ("up")) {
			anim.Play ("player");
		}
		if (Input.GetKey ("down")) {
			transform.Translate (0, -(MoveSpeed * Time.deltaTime), 0);
			anim.Play ("run");
		} else if (Input.GetKeyUp ("down")) {
			anim.Play ("player");
		} 
		if (Input.GetKey ("left")) {
			transform.Translate (-(MoveSpeed * Time.deltaTime), 0, 0);
			anim.Play ("run");
		} else if (Input.GetKeyUp ("right")) {
			anim.Play ("player");
		} 
		if (Input.GetKey ("right")) {
			transform.Translate (MoveSpeed * Time.deltaTime, 0, 0);
			anim.Play ("run");
		} else if (Input.GetKeyUp ("left")) {
			anim.Play ("player");
		} 
		////////////////////////////////////////////////////////////////////////////////
		if (Input.GetKey ("q")) {
			anim.Play ("atk");
			test = true;
		} else if (Input.GetKeyUp ("q")) {
			anim.Play ("player");
			test = false;
		} 
	}
	
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "yee" ) {
			if (test == true){
				print("atkhit");
				Destroy(coll.gameObject);
			}
		}
		if (coll.gameObject.name == "boss") {
			if (test == true) {
				print ("hit");
				boss = GameObject.Find("boss");
				boss.SendMessage("getMessage");
			}
		}
	}
	
	
	void FixedUpdate () {
		float h = Input.GetAxis ("Horizontal");
		
		if (h > 0 && !facingRight)
			flip ();
		else if (h < 0 && facingRight)
			flip ();
	}
	
	
	void flip(){
		
		facingRight = !facingRight;
		
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		
	}
	
}
