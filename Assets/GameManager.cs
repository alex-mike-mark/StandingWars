using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;
	public Text p1Wins;
	public Text p2Wins;
	public HealthScript p1Health;
	public HealthScriptP2 p2Health;
	private bool gameOver;
	private GameManager instance;
	private bool routineRunning;

	//Awake is always called before any Start functions
	void Awake()
	{
		routineRunning = false;

		if (instance == null)

			//if not, set instance to this
			instance = this;

		//If instance already exists and it's not this:
		else if (instance != this)

			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
			Destroy(gameObject);    

		//Sets this to not be destroyed when reloading scene
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(! routineRunning)
		{
		if (p1Health.health < 0.5f) 
		{
			p2Wins.enabled = true;
			gameOver = true;
			routineRunning = true;
			StartCoroutine (reload());
		}

		if (p2Health.health < 0.5f) 
		{
			p1Wins.enabled = true;
			gameOver = true;
			routineRunning = true;
			StartCoroutine (reload());
		}
		}
		
	}

	IEnumerator reload() 
	{
		yield return new WaitForSeconds(3f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
