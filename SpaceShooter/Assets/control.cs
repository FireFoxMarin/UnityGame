﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public UnityEngine.UI.Text scoreLabel;
    public UnityEngine.UI.Image menu;
    public UnityEngine.UI.Button startb;
    public static int score = 0;
    public static bool isStat = false;
    // Start is called before the first frame update
    void Start()
    {
        startb.onClick.AddListener(delegate {
            menu.gameObject.SetActive(false);
            isStat = true;
        });


    }

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = "Score: " + score;



    }
}
