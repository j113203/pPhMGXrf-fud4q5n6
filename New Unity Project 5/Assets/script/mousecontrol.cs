using UnityEngine;
using System.Collections;

public class mousecontrol : MonoBehaviour {
	
		public float sensitivityY = 15.0f;
		/*private Transform cameraTm;
		public bool down = false;*/
		public float speed = 1;
		
		
		void Start ()
		{
			//cameraTm = Camera.mainCamera.transform;
		}
		
		void Update () {
			/*if( Input.GetMouseButtonDown( 0 ) )
				down = true;
			else if( Input.GetMouseButtonUp( 0 ) )
				down = false;
			if( down )
			{
				float rotationX = Input.GetAxis("Mouse X") * sensitivityX;
				float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
				transform.RotateAroundLocal( cameraTm.up, -Mathf.Deg2Rad * rotationX );
				transform.RotateAroundLocal( cameraTm.right, Mathf.Deg2Rad * rotationY );
			}*/
		float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
		transform.Rotate(new Vector3(0,0,Time.deltaTime*rotationY));
		}
}
