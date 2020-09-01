﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed = 7.5f;
    public Rigidbody2D theRB;

    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = transform.right * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        //Destroy(other.gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
