using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dottedline : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10;
    public float time = 20;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
        InvokeRepeating("Switch", 0, time);
    }

    public void Switch()
    {
        rb.velocity *= -1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other){
                 GetComponent<Rigidbody2D>().AddForce(Vector2.down * 2);
                    
    }
private void OnCollisionExit2D(Collision2D other) {
                     GetComponent<Rigidbody2D>().AddForce(Vector2.up * 2);

}
    void OnTriggerEnter2D(Collider2D other)
    {
        // لا تفعل شيئا عند التصادم. يمكنك إضافة منطق هنا إذا كنت ترغب في تنفيذ شيء معين عند التصادم
    }
}