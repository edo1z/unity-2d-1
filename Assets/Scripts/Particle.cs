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

    public static GameObject GetPrefab(GameObject prefab, string path)
    {
        return prefab ?? (prefab = Resources.Load(path) as GameObject);
    }

    static GameObject particle_prefab = null;
    public static Particle add(float x, float y)
    {
        particle_prefab = GetPrefab(particle_prefab, "Prefabs/Particle");
        Vector3 position = new Vector3(x, y, 0);
        float direction = 0.0f;
        float speed = 0.0f;
        GameObject g = Instantiate(particle_prefab, position, Quaternion.identity) as GameObject;
        Particle p = g.GetComponent<Particle>();
        Vector2 v;
        v.x = Mathf.Cos(Mathf.Deg2Rad * direction) * speed;
        v.y = Mathf.Sin(Mathf.Deg2Rad * direction) * speed;
        p.RigidBody.velocity = v;
        return p;
    }

    IEnumerator Start()
    {
        float direction = Random.Range(0, 359);
        float speed = Random.Range(1.0f, 20.0f);
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
