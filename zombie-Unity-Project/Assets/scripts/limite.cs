using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class limite : MonoBehaviour
{
    public GameObject[] haerts;
    public int life;
    public GameObject[] enemy;


    private void Update()
    { 
        if (life < 1)
        {
            Destroy(haerts[0].gameObject);
            SceneManager.LoadScene("Game Over");
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


    
    private void OnBecameInvisible()
    {
        if (tag == "Human")
        {
            life--;
            Destroy(haerts[1]);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            life--;
            Destroy(collision.gameObject);
        }
    }
}
