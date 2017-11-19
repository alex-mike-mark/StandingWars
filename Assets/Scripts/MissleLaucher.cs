using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//transform.parent.gameObject gets the parent.

public class MissleLaucher : MonoBehaviour {
	public Transform[] missleTypes;
	Transform missle;

	int index;
	int length;
	bool changeOK;
	bool fireOneOK;
	GameObject obj;
	Rigidbody2D rb;
	Transform tf;

	// Use this for initialization
	void Start () {
		index = 0;
		missle = missleTypes [index];
		length = missleTypes.Length;
		fireOneOK = true;
		rb = gameObject.GetComponent<Rigidbody2D> ();
		tf = gameObject.GetComponent<Transform> ();
		rb.centerOfMass = new Vector2 (-1, 0);

	}
	
	// Update is called once per frame
	void Update () {
		changeMissle ();
		rotateLauncher ();
		if (Input.GetAxis("Fire1")!=0 && fireOneOK) {
			fireOneOK = false;
			Instantiate(missle, tf.position+tf.forward, Quaternion.identity);
		}
		if (Input.GetAxis("Fire1")==0){
			fireOneOK=true;
		}
	}

	void changeMissle(){
		float input = Input.GetAxis ("Horizontal");
		if (input > 0 && changeOK) {//raise index
			index++;
			if (length <= index) {
				index = 0;					
			}
			changeOK = false;
		} else if (input < 0 && changeOK) {//lower index
			index--;
			if (index < 0) {
				index = length - 1;
			}
			changeOK = false;
		} else if (input == 0) {
			changeOK = true;
		}
		missle = missleTypes [index];
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