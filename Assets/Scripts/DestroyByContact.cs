﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosion;
    public GameObject playerExplosion;
    void OnTriggerEnter(Collider other)
    {
        if (other.name != "Boundary")
        {
            Destroy(other.gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            if (other.name == "Player")
            {
                Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
            }
            Destroy(gameObject);
        }
    }
}
