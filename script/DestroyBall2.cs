﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall2 : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "DestroyBall")
        {
            GameObject.Find("ballSpawner1").GetComponent<SpawnBall>().spawnMe = true;
            Destroy(gameObject);
        }

        //if (other.gameObject.tag == "Cup")
        //{
        //    GameObject.Find("ballSpawner2").GetComponent<SpawnBall2>().spawnMe2 = true;
        //    Destroy(gameObject);
        //}

    }


}
