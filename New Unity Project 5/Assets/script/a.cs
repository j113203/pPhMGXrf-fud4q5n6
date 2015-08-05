using UnityEngine;
using System.Collections;
public class a : MonoBehaviour
{
	// Set MainCamera & Player
	public GameObject objMainCamera;
	public GameObject objPlayer;
	public Camera cam;
	// Movement Varibles
	public int moveSpeed;
	
	// Use this for initialization
	void Start()
	{
		objMainCamera   = GameObject.FindWithTag("MainCamera");
		objPlayer              = GameObject.FindWithTag("Player");
		cam                      = objMainCamera.GetComponent<Camera>();
	}
	// Update is called once per frame
	void Update()
	{
		HandleMovement();
		//HandleInput();
		HandleMainCamera();
	}
	void HandleMainCamera()
	{
		//set MainCamera to the position of Player         
		objMainCamera.transform.position = new Vector3(objPlayer.transform.position.x, 10, objPlayer.transform.position.z - 10);
		//rotate the camera to face the player
		Quaternion rotation = objMainCamera.transform.rotation;
		rotation.eulerAngles = new Vector3(45, 0, 0);
		objMainCamera.transform.rotation = rotation;
	}
	
	void HandleMovement()
	{
		Vector3 targetLocation = new Vector3();
		CharacterController character = GetComponent<CharacterController>();
		bool moving = false;
		Vector3 movement =new Vector3();
		if (Input.GetMouseButton(0))
		{
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit))
			{
				float touchDist;
				touchDist = (transform.position - hit.point).magnitude;
				if (touchDist > 1.0f)
				{
					targetLocation = hit.point;
					moving = true;
				}
			}
		}
		if (moving)
		{
			
			float dist;
			movement = targetLocation - objPlayer.transform.position;
			movement.y = 0;
			dist = movement.magnitude;        //Ä¿±êµØµãµœµ±Ç°µØµãµÄ³€¶È;
			if (dist < 5f)
			{
				moving = false;
			}
			else
			{
				movement = movement.normalized * moveSpeed;
			}
			movement *= Time.deltaTime;
			character.SimpleMove(movement);
		}
	}
}