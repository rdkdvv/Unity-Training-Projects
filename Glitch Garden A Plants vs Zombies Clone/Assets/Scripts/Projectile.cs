﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed, damage;

    private GameObject currentTarget;

    // Use this for initialization
    void Start ()
    {
        
    }
    
    // Update is called once per frame
    void Update ()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Attackers attackers = collider.GetComponent<Attackers>();
        Health health = collider.GetComponent<Health>();

        if (attackers && health)
        {
            health.DealDamage(damage);
            // destroy projectile
            Destroy(gameObject);
        }
    }
}
