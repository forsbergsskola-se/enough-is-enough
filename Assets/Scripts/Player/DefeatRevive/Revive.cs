﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revive : MonoBehaviour
{
    public void ReviveButtom()
    {
        FindObjectOfType<Death>().Die(deadbool: false, playerMovement: true, velocity: Vector3.zero, angularVelocity: Vector3.zero,
            gameOver: false);
        GameObject.FindWithTag("Player").GetComponent<PlayerHealth>().Health = 100;
        Time.timeScale = 1;
    }
}