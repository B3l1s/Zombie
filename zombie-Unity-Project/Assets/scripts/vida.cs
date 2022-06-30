using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{

    public GameObject[] haerts;
    public int life;
    public GameObject[] enemy;


    private void Update()
    {
        if (life < 1)
        {
            Destroy(haerts[0].gameObject);
        }
        else if (life < 2)
        {
            Destroy(haerts[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(haerts[2].gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.tag == "Enemy" && collision)
        {
            life--;
            Destroy(gameObject);
        }
    }
    private void OnBecameInvisible()
    {
        if (tag == "Human")
        {
            life--;
            Destroy(haerts[1]);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.CompareTag("Enemy"))
        {
            Debug.Log("limites");
            Destroy(gameObject);
        }
    }
}
