using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    Rigidbody2D _rigidbody2D = null;
    public Rigidbody2D RigidBody
    {
        get { return _rigidbody2D ?? (_rigidbody2D = gameObject.GetComponent<Rigidbody2D>()); }
    }

    IEnumerator Start()
    {
        float direction = Random.Range(0, 359);
        float speed = Random.Range(10.0f, 20.0f);
        Vector2 v;
        v.x = Mathf.Cos(Mathf.Deg2Rad * direction) * speed;
        v.y = Mathf.Sin(Mathf.Deg2Rad * direction) * speed;
        RigidBody.velocity = v;

        while (transform.localScale.x > 0.01f)
        {
            yield return new WaitForSeconds(0.01f);
            transform.localScale *= 0.9f;
            RigidBody.velocity *= 0.9f;
        }
        Destroy(gameObject);
    }
}
