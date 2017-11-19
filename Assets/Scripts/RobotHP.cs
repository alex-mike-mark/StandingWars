using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotHP : MonoBehaviour {
    int MAX_HP = 100;
    int baseDamage = 10;
    bool isDead = false;
    int hp;
    int rate=1;
    int count;

	// Use this for initialization
	void Start () {
        hp = 60;
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {
        count++;
        if (count >= 60*rate)
        {
            if (!isDead&&hp<MAX_HP)
            {
                hp++;
                Debug.Log(hp);
            }
            
            count = 0;
        }
        if (Input.GetAxis("Fire1") != 0)
        {
            if (!isDead) {
                TakeDamage();
                Debug.Log(hp);
            }
            
            
        }
    }

    void TakeDamage()
    {
        hp -= baseDamage;
        if (hp <= 0)
        {
            isDead = true;
        }
    }

    void TakeDamage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            isDead = true;
        }
    }

    public bool IsDead()
    {
        return isDead;
    }
}
