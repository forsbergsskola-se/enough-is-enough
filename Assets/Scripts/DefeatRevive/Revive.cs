﻿using System.Collections;
using System.Collections.Generic;
using System.Net.Configuration;
using UnityEngine;

public class Revive : MonoBehaviour
{
    public GameObject gameover;
    public bool activeOrNot = false;

    public void ReviveButtom()
    {
        FindObjectOfType<Death>().Die(playerMovement: true, velocity: Vector3.one, angularVelocity: Vector3.one,
            gameOver: false);
        GameObject.FindWithTag("Player").GetComponent<Death>().Health += 100;
        activeOrNot = true;
    }
}