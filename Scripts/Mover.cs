using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;

    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }
}  