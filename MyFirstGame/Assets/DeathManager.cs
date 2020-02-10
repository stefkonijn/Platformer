using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DeathManager : MonoBehaviour
{
    public int deaths = 0;
    public Text deathText;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseDeaths()
    {
        deaths += 1;

        deathText.text = " Deathcounter: " + deaths.ToString();


    }


}
