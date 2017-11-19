using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMissileColl : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D coll)
    {
		if (coll.gameObject.CompareTag ("Player2")) {
			Debug.Log ("BOOM1");
			//coll.gameObject.SetActive (false);
			Destroy (gameObject);
			this.SendMessage ("TakeDamage", 10);
		}
    }
}
