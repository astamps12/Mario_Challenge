﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characteranim : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.RightArrow)){
            anim.SetBool("isRunning", true);
        }
            else{
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        { anim.SetBool("isRunningLeft", true);
        }

            else
        {
            anim.SetBool("isRunningLeft", false);
        }


        if (Input.GetKeyDown(KeyCode.UpArrow)){
            anim.SetTrigger("jump");
        }
    
    }
}
