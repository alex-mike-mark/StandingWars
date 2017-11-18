using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleController : MonoBehaviour {

	//public LineRenderer trajectory;
	public GameObject shooter;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (followLine ());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}


	IEnumerator followLine() 
	{
		
		Vector3 point = shooter.transform.position;


		while (gameObject.activeInHierarchy) 
		{
			this.transform.position = point;
			point.x += 1;
			yield return new WaitForSeconds(0.08f);
		}


	}
}
