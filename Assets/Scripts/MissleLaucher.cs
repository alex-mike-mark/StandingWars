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
	Transform tf;

	// Use this for initialization
	void Start () {
		index = 0;
		missle = missleTypes [index];
		length = missleTypes.Length;
		fireOneOK = true;
		tf = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		changeMissle ();
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
}