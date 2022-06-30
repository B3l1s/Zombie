using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public GameObject objetofind;

    [SerializeField] private float speed;
    [SerializeField] private Transform[] puntos;
    [SerializeField] private float Distancia;
    private int NumeroRandom;
    private SpriteRenderer Sprite;

    void Start()
    {
        NumeroRandom = Random.Range(0, puntos.Length);
        Sprite = GetComponent<SpriteRenderer>();
        Girar();
    }
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntos[NumeroRandom].position, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, puntos[NumeroRandom].position) < Distancia)
        {
            NumeroRandom = Random.Range(0, puntos.Length);
            Girar();

            Quaternion.Euler(0, 0, 100);
        }
    }
    private void Girar()
    {
        if(transform.position.x < puntos[NumeroRandom].position.x)
        {
            Sprite.flipX = true;
        }
        else
        {
            Sprite.flipX = false;
        }
    }

}
