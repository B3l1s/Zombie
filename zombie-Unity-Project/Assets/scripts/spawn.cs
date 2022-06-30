using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField]public float velocidadMovimiento;
    [SerializeField] private Transform[] puntosMovimiento;
    [SerializeField] private float distanceMin;
    private SpriteRenderer spriteRenderer;
    private int elquesigue = 0;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, puntosMovimiento[elquesigue].position, velocidadMovimiento * Time.deltaTime);
        if (Vector3.Distance(transform.position, puntosMovimiento[elquesigue].position) < distanceMin)
        {
            elquesigue += 1;
            if(elquesigue >= puntosMovimiento.Length)
            {
                elquesigue = 0;
            }
            Girar();
        }
    } 
   private void Girar()
    {
        if(transform.position.x < puntosMovimiento[elquesigue].position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }



}
