using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG

{
public class CameraFollow : MonoBehaviour {

	GameObject player;
	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void lateUpdate () 
	{
		transform.position = player.transform.position;
	}
}
}