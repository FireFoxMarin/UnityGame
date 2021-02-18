using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vavilon : MonoBehaviour
{
    public GameObject lazer;
    public GameObject lazer1, lazer2;
    public Transform lazerGun;
    public Transform lazerGun1, lazerGun2;

    public float shotDelay; 
    float nexshotTime = 0;
    float nexshotTime1 = 0;

    public float speed;
    public float tilt;
    public float xMin, xMax, zMin, zMax;
    Rigidbody StarShip;
    // Start is called before the first frame update
    void Start()
    {
        StarShip = GetComponent<Rigidbody>();
    }
      
    // Update is called once per frame
    void Update()
    {
        if (!control.isStat)
        {
            return;
        }

        float moveHorizontal = Input.GetAxis("Horizontal");     
        float moveVertical = Input.GetAxis("Vertical");        

        StarShip.velocity = new Vector3(moveHorizontal, 0, moveVertical)* speed;

        float clampedX = Mathf.Clamp(StarShip.position.x, xMin, xMax);
        float clampedZ = Mathf.Clamp(StarShip.position.z, zMin, zMax);

        StarShip.position = new Vector3(clampedX, 0, clampedZ);

        StarShip.rotation = Quaternion.Euler(StarShip.velocity.z*tilt, 0, -StarShip.velocity.x*tilt);
        
        if (Time.time > nexshotTime && Input.GetButton("Fire1"))
        {
            Instantiate(lazer, lazerGun.position, Quaternion.identity);
            nexshotTime = Time.time + shotDelay;            
        }

        if (Time.time > nexshotTime1 && Input.GetButton("Fire2"))
        {
            Instantiate(lazer1, lazerGun1.position, Quaternion.Euler(0f, -45f, 0f));
            Instantiate(lazer2, lazerGun2.position, Quaternion.Euler(0f, 45f, 0f));

            nexshotTime1 = Time.time + shotDelay/2;            
        }


    }

    void FixedUpdate()
    {

    }

}
