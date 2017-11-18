using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//transform.parent.gameObject gets the parent.

public class MissleLaucher : MonoBehaviour {
	public Transform missle;
	private Vector2 firePoint;

	bool fireOneOK;
	int i;

	// Use this for initialization
	void Start () {
		i = 0;
		fireOneOK = true;
	}
	
	// Update is called once per frame
	void Update () {

		firePoint = gameObject.GetComponent<Transform> ().position;
		firePoint.y -= 3f;

		if (Input.GetAxis("Fire1")!=0 && fireOneOK) {
			fireOneOK = false;
			Instantiate(missle, firePoint, Quaternion.identity);
		}
		if (Input.GetAxis("Fire1")==0){
			fireOneOK=true;
		}
		i++;
	}
}
