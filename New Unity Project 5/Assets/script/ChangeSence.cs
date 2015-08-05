using UnityEngine;
using System.Collections;

public class ChangeSence : MonoBehaviour {
	
	public void ChangeToScene (string scenceToChangeTo) {
		Application.LoadLevel (scenceToChangeTo);
	}
}
