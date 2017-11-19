using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrightLinePlotter : MonoBehaviour {

	public LineRenderer line;
	private Vector3 newPoint;
	public GameObject missle;
	public GameObject enemy;
	public GameObject self;
	private int currPos;

	// Use this for initialization
	void Awake () 
	{
		Vector3 startPoint = self.transform.position;
		line.positionCount = 2;
		line.SetPosition(0, startPoint);
		line.SetPosition(1, startPoint);
		currPos = 0;
		line.SetPosition (currPos,startPoint);
	}

	void OnDestroy() 
	{
		Destroy (line);
	}
	
	// Update is called once per frame
	public void Update () 
	{
		if (line.GetPosition (currPos).x < 25.0f) 
		{
			
			newPoint = line.GetPosition (currPos);
			newPoint.x += 3;
			currPos++;
			line.SetPosition (currPos, newPoint);
			missle.transform.position = line.GetPosition (currPos);
			line.positionCount += 1;


			if (!missle.activeInHierarchy) {
				line.positionCount = 1;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll) 
	{
		if (coll.gameObject.Equals (enemy))
			Destroy (missle);

	}
	public void setMissle (GameObject newMissle)
	{
		this.missle = newMissle;
	}

	public Vector2 getEndPoint()
	{
		return line.GetPosition (line.positionCount - 2);
	}
}
