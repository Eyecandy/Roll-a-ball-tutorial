using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// guaranteed to run after all objects has been processed, each frame.
	void LateUpdate () {

		transform.position = player.transform.position + offset;
	}
}
