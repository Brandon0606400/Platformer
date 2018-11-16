﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statement to allow us to use the scene management functions
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {

    //Designer Variables
    public string sceneToLoad;

    private void OnCollisionEnter2D(Collision2D collision)
    {
    
    //Check if the thing that we collided with
    //is the player (aka has the player script)
    Player playerScript = collision.collider.GetComponent<Player>();

        //Only do someting if the thing we ran into
        //was the player
        //aka playerScript is not null
        if (playerScript != null)
        {
            //We did hit the player
            //Load the next level
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
