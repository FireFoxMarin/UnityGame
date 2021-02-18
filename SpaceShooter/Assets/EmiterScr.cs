using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmiterScr : MonoBehaviour
{

    public float minDelay, maxDelay;
    public GameObject asteroid;
    public GameObject asteroid1;
    public GameObject asteroid2;
    float nexLauTimer = 0;

    public float minDelayPirat, maxDelayPirat;
    public GameObject Pirat;
    float nexLauTimerPirat = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!control.isStat)
        {
            return;
        }
        
        if (Time.time > nexLauTimer)
        {
            GameObject[] asteroids = { asteroid, asteroid1, asteroid2 };

            float posX = Random.Range(-transform.localScale.x / 2, transform.localScale.x / 2);
            float posY = transform.position.y;
            float posZ = transform.position.z;
           
            GameObject Astro = asteroids[Random.Range(0, 2)];

            Instantiate(Astro, new Vector3(posX, posY, posZ), Quaternion.identity);

            nexLauTimer = Time.time + Random.Range(minDelay, maxDelay);
        }

        
        if (Time.time > nexLauTimerPirat)
        {        

            float posXP = Random.Range(-transform.localScale.x / 2, transform.localScale.x / 2);
            float posYP = transform.position.y;
            float posZP = transform.position.z;            

            Instantiate(Pirat, new Vector3(posXP, posYP, posZP), Quaternion.identity);

            nexLauTimerPirat = Time.time + Random.Range(minDelayPirat, maxDelayPirat);
        }


    }
}
