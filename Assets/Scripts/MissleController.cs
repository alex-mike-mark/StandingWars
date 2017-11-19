using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleController : MonoBehaviour {
	Rigidbody2D rb2;

	// Use this for initialization
	void Start () {
		rb2 = gameObject.GetComponent<Rigidbody2D> ();
		rb2.AddForce (100*(new Vector2 (1, 0)));
	}

	// Update is called once per frame
	void Update () {
		rb2.AddForce (new Vector2 (25,0));
	}
}
