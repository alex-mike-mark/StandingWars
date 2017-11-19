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

	// Use this for initialization
	void Start () 
	{
		health = 100;
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
			explosion.gameObject.transform.position = this.transform.position;
			explosion.Play ();
			sprite.sprite = death;
			Debug.Log ("GameOver - Player 1 Wins");
		}	
	}



}
