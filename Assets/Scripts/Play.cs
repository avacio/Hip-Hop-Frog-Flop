using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
	private List<string> movement;
	private string direction;
	public bool onGround;
	public Animator anim;
	private int num;
	private int size;

	void Start ()
	{
		anim = GetComponent<Animator>();
		anim.SetTrigger ("Forward");
//		onGround = true;
		movement = new List<string>(new string[] {"Start", "Left", "Forward", "Right", "Forward", "Right", "Forward", "Left", "Forward", "Right", "Forward","Left","Forward","Right","Forward","Right","Forward","Left","Forward","Left","Forward","Right","Forward","Left","Forward","Right","Forward","Right","Forward","Left","Forward","Left","Forward","Right","Forward","Right","Forward","Left","Forward","Right","Forward","Left","Forward","Left","Forward"});
		num = 0;
	}

	void Update ()
	{
		size = movement.Count;
//
//		if (size > 0 && onGround)
//		{
//			direction = movement [0];
//
//			if (Input.GetKeyDown (KeyCode.Space))
//			{
//				anim.SetTrigger (direction);
//				movement.RemoveAt (0);
//				onGround = false;
//
//			}
//		}
		
		if (onGround && size > 0 && num < size)
		{
			if (movement [num] == "Forward")
			{
				anim.SetTrigger (movement [num]);
				//					movement.RemoveAt (0);
				//					direction = movement [0];
				num++;
			}

			else if (Input.GetKeyDown (KeyCode.Space))
			{
				direction = movement [num];
				anim.SetTrigger (direction);
				onGround = false;
//				movement.RemoveAt (0);
				num++;
			}
		}

	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.CompareTag ("Ground"))
		{
			onGround = true;
		}

		if (other.gameObject.CompareTag ("Water"))
		{
			anim.SetTrigger ("Sink");
		}

		if (other.gameObject.CompareTag ("Lotus"))
		{
			anim.SetTrigger ("Tumble");
		}
	}
}
