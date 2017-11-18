using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrightLinePlotter : MonoBehaviour {

	public LineRenderer line;
	private Vector2 newPoint;
	public GameObject missle;
	public GameObject enemy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		line.positionCount += 1;
		newPoint = line.GetPosition (line.positionCount - 2);
		newPoint.x += 1;
		line.SetPosition (line.positionCount-1,newPoint);

		missle.transform.position = newPoint;
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{
		if (coll.gameObject.Equals (enemy))
			Destroy (missle);

	}
}
