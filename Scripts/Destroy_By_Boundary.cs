using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_By_Boundary : MonoBehaviour
{
   void OnTriggerExit2D(Collider2D other) 
    {
        if (other.tag == "Player Shield")
        {
            return;
        }
        
        Destroy(other.gameObject);
    }

}
