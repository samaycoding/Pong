using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    private Rigidbody2D rb2d;
    private Vector2 vel;
    public float initialVelocity;
    // Use this for initialization
    public ParticleSystem collisionParticlePrefab; //Assign the Particle from the Editor (You can do this from code too)
                                                   //private ParticleSystem tempCollisionParticle;

    public AudioClip hitSound;
    public AudioSource source;

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(initialVelocity, -15));
        }
        else
        {
            rb2d.AddForce(new Vector2(-initialVelocity, -15));
        }
    }
    void Start () {
        
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
        source.clip = hitSound;

    }

    void ResetBall()
    {
        vel = Vector2.zero;
        rb2d.velocity = vel;
        transform.position = Vector2.zero;
    }
    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }



    public AudioSource clickAudio;

   /* void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.name == "Ball")
        {
            clickAudio.Play();
            clickAudio.Play();
        }
    }*/


    public AudioClip Scored;
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            /* clickAudio = GetComponent<AudioSource>();
             clickAudio.clip = Scored;
             clickAudio.Play();
             vel.x = rb2d.velocity.x;
             vel.y = (rb2d.velocity.y / 2.0f) + (coll.collider.attachedRigidbody.velocity.y / 3.0f);
             rb2d.velocity = vel;*/
            if (!source.isPlaying)
                source.Play();
        }
    }

  
}
