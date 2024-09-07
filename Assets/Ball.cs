using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public float speed = 30;
    public float speedIncrease = 0.2f;

    private Rigidbody2D ballRigidbody;

    void Start() {
        // Initial Velocity
        ballRigidbody = GetComponent<Rigidbody2D>();
        ballRigidbody.velocity = Vector2.right * speed;
    }
    
    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                    float racketHeight) {
        // ascii art:
        // ||  1 <- at the top of the racket
        // ||
        // ||  0 <- at the middle of the racket
        // ||
        // || -1 <- at the bottom of the racket
        return (ballPos.y - racketPos.y) / racketHeight;
    }
[SerializeField] private AudioSource pingpongsound;
       

    void OnCollisionEnter2D(Collision2D col) {
         pingpongsound.Play();
         if (col.gameObject.GetComponent<BoxCollider2D>() != null)
        {
            Vector2 newDirection = Vector2.Reflect(ballRigidbody.velocity.normalized, col.contacts[0].normal);
            ballRigidbody.velocity = newDirection.normalized * (speed + speedIncrease);
            if (col.gameObject.name == "RacketLeft") {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            ballRigidbody.velocity = dir * speed;
        }

        // Hit the right Racket?
        if (col.gameObject.name == "RacketRight") {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;
            
            // Set Velocity with dir * speed
            ballRigidbody.velocity = dir * speed;
        }
        }
        // Note: 'col' holds the collision information. If the
        // Ball collided with a racket, then:
        //   col.gameObject is the racket
        //   col.transform.position is the racket's position
        //   col.collider is the racket's collider
        
        // Hit the left Racket?
        
    }
}