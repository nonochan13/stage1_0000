﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowController : MonoBehaviour {
    public GameObject player;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
	}
}