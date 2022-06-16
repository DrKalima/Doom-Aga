using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerController : MonoBehaviour
{
    public Image powerBar;
    public float myPower;
    public float power;
            
    private float currentPower;
                
    void Start()
    {
        currentPower = myPower;
    }
     
    void Update()
    {
               
        if (currentPower < myPower)
        {
            powerBar.fillAmount = Mathf.MoveTowards(powerBar.fillAmount, 1.0f, Time.deltaTime * 0.05f);
            currentPower = Mathf.MoveTowards(currentPower / myPower, 1.0f, Time.deltaTime * 0.05f) * myPower;
        }

        if (currentPower < 0)
        {
            currentPower = 0;
        }

        if (Input.GetKey("space"))
        {
            currentPower -= power;
            powerBar.fillAmount -= power / myPower;
        }

    }
      
}
