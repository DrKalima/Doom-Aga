using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_By_Contact_Shield : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);

        if (other.tag == "Boundary")
        {
            return;
        }
        else if (other.tag == "Player")
        {
            return;
        }
        else if (other.tag == "Player Lazer")
        {
            return;
        }
                        
        Destroy(other.gameObject);
    }

    void DestroyObjectDelayed()
    {
        Destroy(this.gameObject,1);
    }
}
