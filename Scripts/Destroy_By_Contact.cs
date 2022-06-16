using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_By_Contact : MonoBehaviour
{
    public int scoreValue;
    private GameController gameController;
    

    void Start()
    {
        //Scoring
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent <GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
              
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.tag == "Boundary")
        {
            return;        
        }
        else if (other.tag == "Enemy 1")
        {
            return;                         
        }       
        else if (other.tag == "ES Shot 1")
        {
            return;
        }
        else if (other.tag == "Player Shield")
        {
            Destroy(this.gameObject);
            return;
        }

        gameController.AddScore (scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

    
}
