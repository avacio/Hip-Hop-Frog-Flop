//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class Move : MonoBehaviour {
//	public Vector3 initial;
//
//	void Start()
//	{
//		InvokeRepeating ("ChangePosition", 0, 1.20f/30);
//	}
//
//	void ChangePosition ()
//	{
//		transform.position += Vector3.right;
//	}
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public Vector3 initial;
	private bool start;

	void Start()
	{
		start = false;
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Space) &&
			(Time.realtimeSinceStartup >= 9) && (start == false)) {
			start = true;
			DoIt ();
		}
	}

	void DoIt() {
		InvokeRepeating ("ChangePosition", 0, 1.20f/30);
	}

	void ChangePosition ()
	{
		transform.position += Vector3.right;
	}
}