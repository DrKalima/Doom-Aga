using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
   
    public GameObject shot;
    public Transform shotSpawn;
    public float bpm;

    private float nextFire;

    void Update()
    {
        if (GameObject.FindWithTag("Player") == null)
        {
            return;
        }

        if (Time.time > nextFire)
        {
            nextFire = Time.time + (60 / bpm);
            //           this.gameObject clone =
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // as this.gameObject;
        }
               
    }

  
}
