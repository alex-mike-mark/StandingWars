using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//transform.parent.gameObject gets the parent.

public class MissleLaucher : MonoBehaviour {
	public Transform missle;

	bool fireOneOK;
	int i;

	// Use this for initialization
	void Start () {
		i = 0;
		fireOneOK = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Fire1")!=0 && fireOneOK) {
			fireOneOK = false;
			Instantiate(missle, gameObject.GetComponent<Transform>().position, Quaternion.identity);
		}
		if (Input.GetAxis("Fire1")==0){
			fireOneOK=true;
		}
		i++;
	}
}
