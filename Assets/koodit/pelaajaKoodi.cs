using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelaajaKoodi : hahmo {

    [SerializeField]
    private stat health;

    [SerializeField]
    private float healthValue;

    [SerializeField]
    private float maxHealth;



	// Use this for initialization
	protected override void Start () 
    {
        health.Initialize(healthValue, maxHealth);

        base.Start();
	}
	
	// Update is called once per frame
	protected override void Update () 
    {
        GetInput();



        base.Update();
	}


    private void GetInput() 
    {

        direction = Vector2.zero;

        //TAMA AINOASTAAN DEBUNKKAUSTA VARTEN
        if (Input.GetKeyDown(KeyCode.I))
        {
            health.MyCurrentValue -= 4;
        }
        if (Input.GetKeyDown(KeyCode.O))
            health.MyCurrentValue += 4;
        {
            
        }
        //TAMA AINOASTAAN DEBUNKKAUSTA VARTEN


        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;

        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }
    }
}
