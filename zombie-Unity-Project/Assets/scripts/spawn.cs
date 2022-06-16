using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public float velocidadMovimiento;
    [SerializeField] private Transform[] puntosMovimiento;
    [SerializeField] private float distanceMin;
    private SpriteRenderer spriteRenderer;
    private int elquesigue = 0;
    public GameObject enemy;


    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, puntosMovimiento[elquesigue].position, velocidadMovimiento * Time.deltaTime);

        if (Vector3.Distance(transform.position, puntosMovimiento[elquesigue].position) < distanceMin)
        {
            elquesigue += 0;

            if(elquesigue >= puntosMovimiento.Length)
            {
                gameObject.SetActive(false);
            }
        }
    } 
    private void OnBecameVisible()
    {
        Destroy(gameObject);
    }
    private void OnMouseDown()
    {
        Debug.Log("toco");
        Destroy(gameObject);
    }



}
