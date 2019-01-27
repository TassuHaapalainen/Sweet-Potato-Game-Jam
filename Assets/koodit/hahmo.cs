using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class hahmo : MonoBehaviour {

    [SerializeField]
    private float speed;

    private Animator animator; //animaatioo varten

    protected Vector2 direction; //protected pelaajaa varten

	// Use this for initialization
	protected virtual void Start () 
    {
        animator = GetComponent<Animator>(); //animaatioo varten
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        Move();
	}

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        AnimateMovement(direction);
    }

    public void AnimateMovement(Vector2 direction) //animaation suuntaa varten
    {
        animator.SetFloat("x", direction.x);
        animator.SetFloat("y", direction.y);
    }
}
