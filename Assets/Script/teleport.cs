﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour {

	public GameObject Portal;
	public GameObject Player;
	bool ouy=true;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			Debug.Log ("yes");
			StartCoroutine (Teleport ());
		}
	}


	IEnumerator Teleport()
	{
		yield return new WaitForSeconds (0.0001f);
		Player.transform.position = new Vector2 (Portal.transform.position.x, Portal.transform.position.y);
	}
}