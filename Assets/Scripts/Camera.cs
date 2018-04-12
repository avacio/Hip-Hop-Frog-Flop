using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
	public Vector3 myPos;
	public Transform myPlay;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (myPos.x + myPlay.position.x, myPos.y, myPos.z);
		//transform.position = myPlay.position + myPos;
	}
}
