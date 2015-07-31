using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

	// Use this for initialization

	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "yee") {
			print("hit");
		}
	}
}
