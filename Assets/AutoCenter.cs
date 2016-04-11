﻿using UnityEngine;
using System.Collections;
using System;

public class AutoCenter : MonoBehaviour {

	public Transform oculusCamera;
	OptitrackRigidBody currBody; 

	public Vector3 currentOffset;
	// Use this for initialization
	void Start () {
		currBody = GetComponent<OptitrackRigidBody>();
	}

	public void Calibrate(){
		Vector3 targetOffset = new Vector3 (0, ((-1 * oculusCamera.localEulerAngles.y % 360) + ((currBody.currRot.y % 360))), 0f);
		transform.localEulerAngles = targetOffset;
	}
}
