﻿using UnityEngine;
using System.Collections;

public class Poop : MonoBehaviour {

	[SerializeField]
	private Player player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag("Player")) {
			player.Damage(10);
		}
	}

}
