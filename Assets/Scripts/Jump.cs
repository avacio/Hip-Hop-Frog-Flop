using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	public bool onGround;
	private Rigidbody rb;
	private List<string> movement;
	private string direction;

	private float pos_x;
	private float pos_y;
	private float pos_z;


	// Use this for initialization
	void Start () {
		onGround = true;
		movement = new List<string>(new string[] { "", "right", "left", "left", "right", "right", "left", "forward", "right", "forward" });
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (onGround && Input.GetKeyDown (KeyCode.Space)) {
			direction = movement [0];
			pos_x = rb.position.x;
			pos_y = rb.position.y;
			pos_z = rb.position.z;

			if (direction == "forward") {
				rb.AddForce (-95, 100, 0, ForceMode.Impulse);
				onGround = false;
			}
			if (direction == "right") {
				transform.Rotate (0, 20, 0);	
				rb.AddForce (-91, 100, 95, ForceMode.Impulse);
				onGround = false;
			}
			if (direction == "left") {
				transform.Rotate (0, -20, 0);
				rb.AddForce (-91, 100, -95, ForceMode.Impulse);
				onGround = false;
			}
		}
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.CompareTag ("Ground")) {
			onGround = true;
			if (direction == "forward") {
				transform.position = new Vector3 (pos_x - 30, pos_y, pos_z);
			}
			if (direction == "right") {
				transform.Rotate (0, -20, 0);
				transform.position = new Vector3 (pos_x - 30, pos_y, pos_z + 30);
			}
			if (direction == "left") {
				transform.Rotate (0, 20, 0);
				transform.position = new Vector3 (pos_x - 30, pos_y, pos_z - 30);
			}
			movement.RemoveAt (0);
		}
	}
}