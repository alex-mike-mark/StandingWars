using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MissleControllerP2 : MonoBehaviour {

	//public LineRenderer trajectory;
	public GameObject shooter;
	public GameObject enemy;
	private Rigidbody2D rb;
	private bool goingUp;
	float arc = 10f;

	// Use this for initialization
	void Start () 
	{



		//Quaternion rotate = shooter.transform.rotation;
		//rotate.z = -29.7f;

		this.transform.Rotate (new Vector3(0f,-180f,-29.7f));
		StartCoroutine (straightLine());
		//this.transform.position = shooter.transform.position;
		//rb = this.gameObject.GetComponent <Rigidbody2D>();
		//goingUp = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*if (goingUp) 
		{
			rb.AddForce (transform.right*3);
			rb.AddForce (transform.up * (arc));

		}

		if (!goingUp) 
		{
			rb.AddForce (transform.right * 3);
			rb.AddForce (transform.up * (arc*-1));

		}

		if (this.transform.position.y >= 2) 
		{
			goingUp = false;
			transform.rotation.Set (0f,0f,25f,0f);
		}

		if (this.transform.position.y <= -3) 
		{
			goingUp = true;
			transform.rotation.Set (0f,0f,-20f,0f);
		}*/

	}


	IEnumerator straightLine() 
	{
		
		Vector3 point = shooter.transform.position;

		while (gameObject.activeInHierarchy) 
		{
			this.transform.position = point;
			point.x -= 1;
			yield return new WaitForSeconds(0.08f);
		}


	}


	IEnumerator zigZagLine() 
	{
		float pitch = 1.5f;
		int pitchToogle = 0;
		Vector3 point = shooter.transform.position;
		Vector3 target = shooter.transform.position;
		target.x -= 1;
		target.y += pitch;



		bool goingUp = true;
	

		while (gameObject.activeInHierarchy) 
		{
			if (pitchToogle > 5 && goingUp) 
			{
				pitch = -1.5f;
				goingUp = false;
				pitchToogle = 0;
				//this.GetComponent <Rigidbody2D>().AddForce(new Vector2 (0f,1f));
				this.GetComponent <Rigidbody2D>().AddTorque(transform.up.y * pitch * 40);
				this.GetComponent <Rigidbody2D>().AddTorque(transform.forward.x * pitch * 40);

			
			}

			if (pitchToogle > 5 && !goingUp) 
			{
				pitch = 1.5f;
				goingUp = true;
				pitchToogle = 0;
				//this.transform.Rotate (0f,0f,85f);
				this.GetComponent <Rigidbody2D>().AddTorque(transform.up.y * pitch * 40);
				this.GetComponent <Rigidbody2D>().AddTorque(transform.forward.x * pitch * 40);
			}



			this.transform.position = point;
			point.x += 0.25f;
			point.y += pitch;
			pitchToogle++;
			yield return new WaitForSeconds(0.08f);
		}


	}


	IEnumerator rando()
	{
		float pitch = 5f;
		Vector3 point = shooter.transform.position;
		this.transform.position = point;
		while (gameObject.activeInHierarchy) 
		{
			//this.transform.position = point;
			//point.x += 1;
			pitch = UnityEngine.Random.Range (-6f, 8f);
			this.GetComponent <Rigidbody2D>().AddForce (transform.right * 10);
			this.GetComponent <Rigidbody2D>().AddForce (transform.up * (pitch *-10));

			if (this.transform.up != enemy.transform.right) 
			{
				this.transform.Rotate (0f,0f,5f);
			}

			//this.GetComponent <Rigidbody2D>().AddTorque(enemy.transform.up.y * arc);
			//this.GetComponent <Rigidbody2D>().AddTorque(transform.forward.x * pitch * 5);
			//yield return new WaitForSeconds(0.08f);
			yield return null;
		}
	}



}
