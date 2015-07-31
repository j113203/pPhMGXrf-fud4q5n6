using UnityEngine;
using System.Collections;

public class weaponUIcall : MonoBehaviour {
	
	private GameObject WeaponUI;
	bool UI = false;


	void Awake () {
		WeaponUI = GameObject.Find("weapon");

	}
	void Start () {
		WeaponUI.SetActive (false);
	}
	

	void Update () {
		if (Input.GetKeyDown (KeyCode.A)) {
			UI = true;
			WeaponUI.SetActive (UI);
			print ("printed");
		} if (Input.GetKeyUp(KeyCode.A)) {
			WeaponUI.SetActive (false);
		}
	}
}
