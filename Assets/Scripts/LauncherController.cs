using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour {

	Rigidbody2D rb;
	Transform tf;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody2D> ();
		tf = gameObject.GetComponent<Transform> ();
		rb.centerOfMass = new Vector2 (-1, 0);
	}
	
	// Update is called once per frame
	void Update () {
		rotateLauncher();
	}

	void rotateLauncher(){
		float input = Input.GetAxis ("Vertical");
		float angleZ = tf.eulerAngles.z;

		if (input > 0) {
			rb.AddTorque (10);
		} else if (input < 0) {
			rb.AddTorque (-10);
		}


		if (angleZ > 45 && angleZ < 180) {
			angleZ = 45;
		} else if (angleZ < 315 && angleZ < 180 ) {
			angleZ = -15;
		}
	}
}
