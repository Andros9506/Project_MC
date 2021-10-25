﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour
{
    public Transform ShootPoint;
    public GameObject BulletPrefab;
    public int timeToDespown = 1;
    public float attackRate = 2f;
    float nextAttackTime = 0f;
    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Shoot()
    {
        GameObject bullet;
        bullet = Instantiate(BulletPrefab, ShootPoint.position, ShootPoint.rotation);
        Destroy(bullet.gameObject, timeToDespown);
    }
}
