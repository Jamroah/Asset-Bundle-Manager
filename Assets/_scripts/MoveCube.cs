﻿using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.Cos(Time.timeSinceLevelLoad), 0, 0);
	}
}
