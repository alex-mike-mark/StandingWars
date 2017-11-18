using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleController : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Transform tf = gameObject.GetComponent<Transform> ();
		tf = tf + new Vector3 (0f, .05f, 0f);
	}
}
