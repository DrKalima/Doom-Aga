using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_by_Contact_ES1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        if (other.tag == "ES Shot 1")

        {
            return;
        }
        
        else if (other.tag == "Boundary")

        {
            return;
        }

        else if (other.tag == "Enemy 1") 
        {
            return;        
        }

        else if (other.tag == "Player Lazer") 
        {
            Destroy(this.gameObject);
            return;
        }
        else if (other.tag == "Player Shield")
        {
            Destroy(this.gameObject);
            return;
        }
                           
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
