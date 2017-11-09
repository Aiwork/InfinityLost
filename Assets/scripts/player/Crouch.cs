using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{

	private bool crouching;
	private CharacterController character;
	public float crouchDeltaHeight = 0.4f;

	private Transform transform;
	// Use this for initialization
	void Start () {
		character = GetComponent<CharacterController>();
		transform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
 	
		if (Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.LeftControl))
		{
			transform.position = new Vector3(transform.position.x, transform.position.y - crouchDeltaHeight, transform.position.z);
			character.height = 0.5f; //crouch height
		}
		else if(Input.GetKeyUp(KeyCode.C)|| Input.GetKeyUp(KeyCode.LeftControl)){
			transform.position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
			character.height = 1.8f; //crouch height
		}
	}

}
