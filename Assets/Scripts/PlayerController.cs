﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class PlayerController : MonoBehaviour
{

    public float speed;
    public Rigidbody2D myRigid;
    public int soldiercount;
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hori = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");
        Vector2 myForce = new Vector2(hori, verti);
        myRigid.AddForce(myForce * speed);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        print("Collision!");
        if (collision.gameObject.tag == "Soldier")
        {
            if (soldiercount < 3)
            {
                collision.gameObject.SetActive(false);
            
                soldiercount++;
            }

        }
        if(collision.gameObject.tag == "Tree")
        {
            this.gameObject.SetActive(false);
            gameOverText.gameObject.SetActive(true);
        }
    }
}

