#pragma strict

var bullet : Rigidbody;
var power : float = 1500;
var moveSpeed : float = 5;

function Start () {

}

function Update () {  // Called for every frame
                // "A", "D", Left, Right arrow, -1 to +1
	var h : float = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
	            // "W", "S", Up, Down arrow, -1 to +1
	var v : float = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
	transform.Translate (h, v, 0); // Move by h and v
	if (Input.GetButtonUp("Fire1")) { // if Left ctrl key up or left move button up
	    // instance is a reference to a new instance of rigidbody
	                             //Instance (what to make, where to make, the rotation)
		var instance : Rigidbody = Instantiate (bullet, transform.position, transform.rotation);
		// fwd holds the forward direction of the attached object
		                          // TransformDirection to convert local direction to world direction
		                                             // Vector3.forward is Vector3(0, 0, 1)
		var fwd: Vector3 = transform.TransformDirection(Vector3.forward);
		instance.AddForce(fwd * power);
	}
}