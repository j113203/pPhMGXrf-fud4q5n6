#pragma strict

public var moveSpeed : float = 5;



function Start () {
	
}

function Update () {

	var h : float = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
	
	        
	var v : float = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
	
	
	transform.Translate (h, v, 0); 
}
