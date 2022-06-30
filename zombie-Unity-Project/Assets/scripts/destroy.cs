using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroy : MonoBehaviour
{
    private GameObject[] haerts;
    public AudioSource source;
    public AudioClip audioFX;
    public int life;
    public Animator animacion;

  private void OnMouseDown()
    {
        //  source.PlayOneShot(audioFX);
        life--;
        AudioSource.PlayClipAtPoint(audioFX, gameObject.transform.position);
       // gameObject.SetActive(false);
        if(life <= 0)
        {
            Destroy(gameObject, 1f);
            GetComponent<CapsuleCollider2D>().enabled  = false;
            GetComponent<Movimiento>().enabled = false;
            animacion.SetBool("Explosion", true);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.tag == "enemy" && collision)
        {
            Destroy(collision);
        }
    }
    public void MyOnDestroy()
    {
        Destroy(gameObject);
    }


}
