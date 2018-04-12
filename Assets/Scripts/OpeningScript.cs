using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningScript : MonoBehaviour {
	public Text title; // Assign the text to this in the inspector
	public Text instructions;
	public float fadeOutLevel;
	private Color titleCol;
	private Color instrCol;
	public bool started;
	public AudioSource introLoop;
	public AudioSource song;
//	private Animator anim;

	void Start () {
		introLoop.Play ();
		song.Stop ();
//		anim = GetComponentInParent<Animator>();
		title.text = "";
		instructions.text = "";
		StartCoroutine(Delay());
		started = false;

	}


	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (!started) {
				introLoop.Stop ();
				song.Play ();
				started = true;
//				anim.SetTrigger ("Start");
			}

			InvokeRepeating ("Fade", 0, 0.5f);

//			if (titleCol.a != 0f) {
//				titleCol.a -= fadeOutLevel; 
//				title.color = titleCol;
//			}
//			if (instrCol.a != 0f) {
//				instrCol.a -= fadeOutLevel; 
//				instructions.color = instrCol;
//			}
			instructions.text = "tap to switch lanes";
		}
	}

	void Fade()
	{
		if (titleCol.a != 0f) {
			titleCol.a -= fadeOutLevel; 
			title.color = titleCol;
		}
		if (instrCol.a != 0f) {
			instrCol.a -= fadeOutLevel; 
			instructions.color = instrCol;
		}
	}

	IEnumerator Delay()
	{
		yield return new WaitForSeconds(4);
		title.text = "Hip Hop Frog Flop";
		titleCol = title.color;
		yield return new WaitForSeconds(2);
		instructions.text = "tap to start";
		instrCol = instructions.color;
	}
}
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//
//public class OpeningScript : MonoBehaviour {
//	public Text title; // Assign the text to this in the inspector
//	public Text instructions;
//	public float fadeOutLevel;
//	private Color titleCol;
//	private Color instrCol;
//	private bool started;
//	public AudioSource introLoop;
//
//	// Use this for initialization
//	void Start () {
////		introLoop.Play ();
////		title.text = "";
////		instructions.text = "";
////		StartCoroutine(Delay());
////		started = false;
//	}
//
//
//	void Update () {
//		if (Input.GetKeyDown (KeyCode.Space)) {
//			if (!started) {
//				introLoop.Stop ();
//			}
//			started = true;
//
//			if (titleCol.a != 0f) {
//				titleCol.a -= fadeOutLevel; 
//				title.color = titleCol;
//			}
//			if (instrCol.a != 0f) {
//				instrCol.a -= fadeOutLevel; 
//				instructions.color = instrCol;
//			}
//			instructions.text = "press space to switch lanes";
//		}
//	}
//
//	IEnumerator Delay()
//	{
//		yield return new WaitForSeconds(4);
//		title.text = "Hip Hop Frog Flop";
//		titleCol = title.color;
//		yield return new WaitForSeconds(2);
//		instructions.text = "Press space to start";
//		instrCol = instructions.color;
//	}
//}