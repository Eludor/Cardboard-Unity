﻿using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {
	//public Camera cameraleft;
	//public Camera cameraright;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 dir = Vector3.zero;
		
		// we assume that the device is held parallel to the ground
		// and the Home button is in the right hand
		
		// remap the device acceleration axis to game coordinates:
		// 1) XY plane of the device is mapped onto XZ plane
		// 2) rotated 90 degrees around Y axis
		dir.x = -Input.acceleration.y;
		dir.z = Input.acceleration.x;
		
		// clamp acceleration vector to the unit sphere
		if (dir.sqrMagnitude > 1)
			dir.Normalize();



		if (Input.GetKey (KeyCode.RightArrow)) {
		transform.Rotate (0,5*Time.deltaTime,0);

		}
		transform.Rotate (dir);


	}
}
