using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parateScr : MonoBehaviour
{
    public GameObject lazer;   
    public Transform lazerGun;

    public GameObject shipEx;

    public float shotDelay; 
    float nexshotTime = 0;    

    public float speed;

    Rigidbody StarShip;
    // Start is called before the first frame update
    void Start()
    {
        StarShip = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     

        StarShip.velocity = new Vector3(0, 0, -1) * speed;

        StarShip.rotation = Quaternion.Euler(0, 180f, 0);

      
        if (Time.time > nexshotTime)
        {
            Instantiate(lazer, lazerGun.position, Quaternion.identity);
            nexshotTime = Time.time + shotDelay;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn" || other.tag == "Asteroid")
        {
            return;
        }

        

        if (other.tag == "Player")
        {
            Instantiate(shipEx, transform.position, Quaternion.identity);
            Instantiate(shipEx, transform.position, Quaternion.identity);

            Destroy(gameObject);
               Destroy(other.gameObject); 
        }

       

    }
}
