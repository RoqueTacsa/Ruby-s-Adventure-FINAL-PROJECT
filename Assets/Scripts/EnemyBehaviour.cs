using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float speed;
    public bool MoveRight;
    public float Hitpoints;
    public float MaxHitpoints =5;

    public ParticleSystem smokeEffect;
    
    Rigidbody2D rigidbody2D;

    void Start()
    {
        Hitpoints = MaxHitpoints;
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        if(Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Update () {
        if(MoveRight){
            transform.Translate(2 * Time.deltaTime * speed , 0,0);
            transform.localScale= new Vector2 (4.8f,4.8f);
        }
        else{
            transform.Translate(-2 * Time.deltaTime * speed , 0,0);
            transform.localScale= new Vector2 (-4.8f,4.8f);
        }
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("turn")){

            if(MoveRight){
                MoveRight = false;
            }
            else{
                MoveRight = true;
            }
        }
    }
    

    void OnCollisionEnter2D(Collision2D other)
    {
        RubyController player = other.gameObject.GetComponent<RubyController >();

        if (player != null)
        {
            player.ChangeHealth(-2);
        }
    }
}