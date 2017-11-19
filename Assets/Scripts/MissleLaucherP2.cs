using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//transform.parent.gameObject gets the parent.

public class MissleLaucherP2 : MonoBehaviour {
	public Transform missle;
	public GameObject shooter;
	private Vector3 firePoint;

	bool fireOneOK;

	// Use this for initialization
	void Start () {


		//firePoint = shooter.transform.position;
		//firePoint.y -= 1f;
		//firePoint.x = 4.65f;
		fireOneOK = true;
	}
	
	// Update is called once per frame
	void Update () {

		firePoint = shooter.transform.position;
		firePoint.x = 4.65f;

				if (Input.GetKeyDown(".") && fireOneOK) {
					fireOneOK = false;
					Instantiate (missle, firePoint, Quaternion.identity);
				}
				if (Input.GetKeyDown(".")) {
					fireOneOK = true;
				}
	
	}
}
