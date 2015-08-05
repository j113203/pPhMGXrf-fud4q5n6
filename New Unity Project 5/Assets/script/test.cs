using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {





	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "yee") {
			print("yee");
		}
	}
}
