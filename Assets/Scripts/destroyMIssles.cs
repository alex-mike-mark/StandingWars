using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class destroyMIssles : MonoBehaviour {

	public GameObject P1;
	public GameObject P2;

	void OnEnable()
	{
		
		if (this.gameObject.name == "Rocket(Clone)") 
		{
			P1 = this.gameObject.GetComponent <MissleController> ().shooter;
			P2 = this.gameObject.GetComponent <MissleController> ().enemy;
		}

		if (this.gameObject.name == "RocketP2(Clone)") 
		{
			P1 = this.gameObject.GetComponent <MissleController> ().shooter;
			P2 = this.gameObject.GetComponent <MissleController> ().enemy;
		}

	}


	void OnCollisionEnter2D(Collision2D coll) 
	{
		


		if (this.gameObject.tag == "Player2" && coll.gameObject.tag == "Missle") {
			P2.GetComponent <HealthScriptP2> ().health -= 10f;
			iTween.ShakePosition (this.gameObject, this.transform.right * 0.05f, 0.75f);
			coll.gameObject.SetActive (false);
			Destroy(coll.gameObject);
		} 
		else if (this.gameObject.tag == "Player1" && coll.gameObject.tag == "Missle") {
			P1.GetComponent <HealthScript> ().health -= 10f;
			iTween.ShakePosition (this.gameObject, this.transform.right * 0.05f, 0.75f);
			coll.gameObject.SetActive (false);
			Destroy(coll.gameObject);
		}
		else if (this.gameObject.tag == "Missle" && coll.gameObject.tag == "Player2") {
			P2.GetComponent <HealthScriptP2> ().health -= 10f;
			iTween.ShakePosition (this.gameObject, this.transform.right * 0.05f, 0.75f);
			this.gameObject.SetActive (false);
			Destroy(this.gameObject);
		}
		else if (this.gameObject.tag == "Missle" && coll.gameObject.tag == "Player1") {
			P2.GetComponent <HealthScript> ().health -= 10f;
			iTween.ShakePosition (this.gameObject, this.transform.right * 0.05f, 0.75f);
			this.gameObject.SetActive (false);
			Destroy(this.gameObject);
		}
		else 
		{
			coll.gameObject.SetActive (false);
			Destroy(coll.gameObject);
		}

	}
}
