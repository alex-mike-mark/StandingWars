using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMissileColl : MonoBehaviour {


    void OnCollisionEnter2D(Collision2D coll)
    {
        coll.gameObject.SetActive(false);
        Destroy(coll.gameObject);
        this.SendMessage("TakeDamage", 10);
    }

}
