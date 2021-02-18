using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroler : MonoBehaviour
{
    public float speed;
    Vector3 startPos;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;


    }

    // Update is called once per frame
    void Update()
    {

        float offset = Mathf.Repeat(Time.time * speed, 150);
        transform.position = startPos + new Vector3(0, 0, -offset);


    }
}
