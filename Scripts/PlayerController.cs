using UnityEngine;
using System.Collections;
using System.Collections.Specialized;
using System.Threading;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float xMin, xMax;

    // lazer beams
    public GameObject shot;
    public Transform shotSpawn;
    public float bpm;
    
    private float nextFire;
    
    // shield
    public GameObject shield;
    public Transform shieldSpawn;
    public float shieldPower;
    public float powerCost;

    private float shieldPowerCurrent;
     
    void Start()
    {
        shieldPowerCurrent = shieldPower;
    }
    
    void Update ()
    {
                
        if (Time.time > nextFire)
        {
            nextFire = Time.time + (60/bpm);
 //           GameObject clone =
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation); // as GameObject;
        }

        if (shieldPowerCurrent < shieldPower)
        {
            shieldPowerCurrent = Mathf.MoveTowards(shieldPowerCurrent / shieldPower, 1.0f, Time.deltaTime * 0.05f) * shieldPower;
        }

        if (Input.GetKey("space") && shieldPowerCurrent > 0.9f)
        {
            Instantiate(shield, shieldSpawn.position, shieldSpawn.rotation);
        }

        
        if (shieldPowerCurrent < 0)
        {
            shieldPowerCurrent = 0;
        }

        if (Input.GetKey("space"))
        {
            shieldPowerCurrent -= powerCost;            
        }
    }
       
    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVeritcal = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
        this.gameObject.GetComponent<Rigidbody2D>().velocity = movement * speed;

        this.gameObject.GetComponent<Rigidbody2D>().position = new Vector3
            (
            Mathf.Clamp(this.gameObject.GetComponent<Rigidbody2D>().position.x, xMin, xMax),
            -23.0f,
            0.0f
            );       
    }

}
