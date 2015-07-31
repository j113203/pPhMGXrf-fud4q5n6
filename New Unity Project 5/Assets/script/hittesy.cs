using UnityEngine;
using System.Collections;

public class hittesy : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "player"){
			print("yeeeeeeeeeeeeee");
		}
	}
}