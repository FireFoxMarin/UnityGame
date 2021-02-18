using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer1 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(-45, 0, speed);

    }
}
