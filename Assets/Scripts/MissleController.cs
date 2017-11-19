using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleController : MonoBehaviour {

	public LineRenderer trajectory;
	public GameObject shooter;

	// Use this for initialization
	void Start () 
	{
	/*	if(this.transform.position != trajectory.GetPosition (0))
		{
			transform.position = Vector3.Lerp(this.transform.position, trajectory.GetPosition (0), 5f);
		}*/
		StartCoroutine (followLine ());
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}


	IEnumerator followLine() 
	{
		int i = 0;



		while (gameObject.activeInHierarchy) 
		{
			

			//this.gameObject.transform.position = trajectory.GetPosition (i);
			this.gameObject.transform.position = Vector3.Lerp(this.gameObject.transform.position, trajectory.GetPosition (i), 5f);
			i++;
			yield return new WaitForSeconds(0.08f);
		}

		Destroy (trajectory);
	}
}
