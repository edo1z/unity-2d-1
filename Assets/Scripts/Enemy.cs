using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int count = 0;

    Rigidbody2D _rigidbody2D = null;
    public Rigidbody2D rigidBody
    {
        get { return _rigidbody2D ?? (_rigidbody2D = gameObject.GetComponent<Rigidbody2D>()); }
    }

    void Start(){
      count++;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Vector2 position = transform.position;
            for (int i = 0; i < 300; i++)
            {
                Particle.add(position.x, position.y);
            }
            Destroy(gameObject);
            count--;
        }
    }
}
