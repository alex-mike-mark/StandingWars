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


		float rotationZ = transform.localEulerAngles.z;

		if(rotationZ > 180 && rotationZ > 315)
		{
			rb.MoveRotation (315);
			rb.angularVelocity = 0;
		}
		else if(rotationZ > 45)
		{
			rb.MoveRotation (45);
			rb.angularVelocity = 0;
		}

	}
}
