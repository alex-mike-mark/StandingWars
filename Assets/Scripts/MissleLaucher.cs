using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleLaucher : MonoBehaviour {
	public Transform missle;
	int i;

	// Use this for initialization
	void Start () {
		i = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (i % 100 == 0) {
			Instantiate(missle, new Vector3(0,i/100,0), Quaternion.identity);
		}
		i++;
	}
}
