﻿using System.Collections;
using System.Collections.Generic;
using System.Net.Configuration;
using UnityEngine;

public class Revive : MonoBehaviour
{
    public void ReviveButtom()
    {
        FindObjectOfType<Death>().Die(playerMovement: true, velocity: Vector3.zero, angularVelocity: Vector3.zero,
            gameOver: false);
        GameObject.FindWithTag("Player").GetComponent<Death>().Health += 100;
    }
}