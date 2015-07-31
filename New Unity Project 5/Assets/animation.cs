using UnityEngine;
using System.Collections;

	public class animation : MonoBehaviour {

	protected Animator animator;

	void start(){
		animator = GetComponent<Animator>();
	}
	void Update () {


		if(Input.GetButtonDown("LeftArrow")){
			animator.SetBool("run",true);
			animator.SetBool("player",false);
		}
		if (Input.GetButtonDown ("rightArrow")) {
			animator.SetBool ("run", true);
			animator.SetBool ("player", false);
		} else {
			animator.SetBool ("run", false);
			animator.SetBool ("player", true);
			}
		}
	}
