using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovementBehavior : MonoBehaviour
{
    public float speed;
    private Vector2 target;
    private Vector2 position;

    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * -speed;
    }

    void Update()
    {
        float step = speed * Time.deltaTime;

        // 'target' finds Player ship Vector2 position and 'position' finds current ES1 position
        if (GameObject.FindWithTag("Player") != null)
        {
            target = GameObject.FindWithTag("Player").transform.position;
            position = this.gameObject.transform.position;

            // moves ES1 towards the target
            this.gameObject.transform.position = Vector2.MoveTowards(transform.position, target, step);
        }

        else
        {
            return;
        }
    }
}    
