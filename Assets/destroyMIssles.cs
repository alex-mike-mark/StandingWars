using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMIssles : MonoBehaviour {

	void OnCollisionEnter(Collider other) 
	{
		Destroy(other.gameObject);
	}
}
