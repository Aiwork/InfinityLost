using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{

	public GameObject [] weapons;
	public int indexWeapon;

	public Transform tranform;
	// Use this for initialization
	void Start ()
	{
		tranform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!Input.GetKeyDown(KeyCode.Q)) return;
		indexWeapon++;
		foreach (Transform child in transform)
		child.gameObject.SetActive(false);
		if (indexWeapon >= transform.childCount)
		{
			indexWeapon = 0;
		} 
		transform.GetChild(indexWeapon).gameObject.SetActive(true);
	}
}
