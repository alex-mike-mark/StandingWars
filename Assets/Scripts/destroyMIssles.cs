using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class destroyMIssles : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) 
	{
		coll.gameObject.SetActive (false);
		Destroy(coll.gameObject);

		if (this.gameObject.tag == "Player2") 
		{
			this.GetComponent <HealthScript>().health -= 10f;
			iTween.ShakePosition (this.gameObject , this.transform.right * 0.05f , 0.75f );
		}

	}
}
