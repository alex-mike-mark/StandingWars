using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//transform.parent.gameObject gets the parent.

public class MissleLaucher : MonoBehaviour {
	public Transform missle;
	private Vector3 firePoint;

	bool fireOneOK;

	// Use this for initialization
	void Start () {

		firePoint = gameObject.GetComponent<Transform> ().position;
		fireOneOK = true;
	}
	
	// Update is called once per frame
	void Update () {

		firePoint = gameObject.GetComponent<Transform> ().position;
		firePoint.y -= 1f;
		firePoint.x -= 5;

		if (Input.GetAxis("Fire1")!=0 && fireOneOK) {
			fireOneOK = false;
			Instantiate(missle, firePoint, Quaternion.identity);
		}
		if (Input.GetAxis("Fire1")==0){
			fireOneOK=true;
		}
	}
}
