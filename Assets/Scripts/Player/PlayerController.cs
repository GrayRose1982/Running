using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Animator anim;
	public Rigidbody2D rigid;
	public bool isRunning = true;

	void Start ()
	{
		
	}

	void Update ()
	{
		if (isRunning && Input.GetKeyDown (KeyCode.Space)) {
			anim.SetTrigger ("Jump");
			isRunning = false;
			rigid.AddForce (new Vector2 (0, 300f));
		}
	}

	void OnCollisionEnter2D (Collision2D hit)
	{
		if (!isRunning && hit.transform.CompareTag ("Land")) {
			anim.SetTrigger ("Landing");
			isRunning = true;
		}
	}
}
