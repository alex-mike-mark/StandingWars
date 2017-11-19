using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

	public Slider healthBar;
	public Image healthBarFill;
	public float health;
	public ParticleSystem explosion;
	public SpriteRenderer sprite;
	public Sprite death;
	private Vector3 renderPoint;

	// Use this for initialization
	void Start () 
	{
		health = 100;
		renderPoint = this.transform.position;
		renderPoint.z = -3f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		healthBar.value = health;

		if (health < 35f) 
		{
			healthBarFill.color = Color.red;
		}


		if(health < 0.5f)
		{
			explosion.gameObject.transform.position = renderPoint;
			if (!explosion.isPlaying) 
			{
				explosion.Play ();
			}
			sprite.sprite = death;
			healthBar.gameObject.SetActive (false);
			iTween.ShakePosition (this.gameObject, this.transform.right * 0.05f, 10f);
			this.GetComponent <MissleLaucher>().enabled = false;
			Debug.Log ("GameOver - Player 2 Wins");
		}	
	}



}
