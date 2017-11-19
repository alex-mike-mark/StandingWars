using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMissileCollP2 : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.CompareTag ("Player1")) {
			Debug.Log ("BOOM2");
			//coll.gameObject.SetActive (false);
			Destroy (gameObject);
			this.SendMessage ("TakeDamage", 10);
		}
	}
		

}
