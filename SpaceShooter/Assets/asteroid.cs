using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    public float rotationSpeed;
    public float Speed;
    public GameObject asteroidEx;
    public GameObject shipEx;

    float size;

    // Start is called before the first frame update
    void Start()
    {
        size = Random.Range(0.5f, 2.0f);

        Rigidbody Asteroid = GetComponent<Rigidbody>();
        Asteroid.angularVelocity = Random.insideUnitSphere * rotationSpeed;


        float speedX = 0;
        if (Random.Range(0, 100) < 30)
        {
            speedX = Speed*Random.Range(-0.5f,0.5f);
        }
        Asteroid.velocity = new Vector3(speedX, 0, -Speed) / size;
        Asteroid.transform.localScale *= size;



    }    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Asteroid" || other.tag == "Pirate" || other.tag == "bound")
        {
            return;
        }

        Instantiate(asteroidEx, transform.position, Quaternion.identity);

        if(other.tag == "Player")
        {
            Instantiate(shipEx, transform.position, Quaternion.identity);
            control.isStat = false;
        }

        control.score += 10;       

        Destroy(gameObject);
        Destroy(other.gameObject); 







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}