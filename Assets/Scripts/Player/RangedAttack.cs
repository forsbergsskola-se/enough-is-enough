﻿using Player;
using UnityEngine;

public class RangedAttack : MonoBehaviour
{
    private Animator anim;
    public GameObject projectile;
    public float chargeUpTime;
    public float chargeCounter;
    public Vector3 targetPos;
    public bool hasATarget;
    public GameObject ChargeBar;

    private void Start()
    {
        chargeCounter = chargeUpTime;
        anim = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        ChargeAttack();

        if (Input.GetMouseButtonDown(0))
        {
            chargeCounter = chargeUpTime;
        }
    }

    private void ChargeAttack()
    {
        if (Input.GetMouseButton(1))
        {
            if (hasATarget)
            {
                ChargeBar.SetActive(true);
                anim.SetTrigger("ToRanged");
                chargeCounter -= Time.deltaTime;
            }
        }
        else if (chargeCounter <= 0 && Input.GetMouseButtonUp(1))
        {
            ChargeBar.SetActive(false);
            Instantiate(projectile, transform.position, Quaternion.identity);
            transform.LookAt(targetPos);
        }
        else
        {
            chargeCounter = chargeUpTime;
        }
    }
}