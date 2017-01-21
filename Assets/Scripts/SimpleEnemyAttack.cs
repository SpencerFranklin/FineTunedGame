﻿using UnityEngine;
using System.Collections;

public class SimpleEnemyAttack : MonoBehaviour {

	public int damageDealt;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.GetComponent<SimplePlayerHealth> ()) {
			col.gameObject.GetComponent<SimplePlayerHealth> ().TakeDamage (damageDealt);
		}
	}
}
