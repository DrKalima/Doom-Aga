using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_By_Contact_Player_Lazer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Boundary")
        {
            return;
        }

        else if (other.tag == "Player") 
        {
            return;
        }

        else if (other.tag == "ES Shot 1")
        {
            Destroy(other.gameObject);
            return;
        }

        else if (other.tag == "Player Shield")
        {
            return;
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
