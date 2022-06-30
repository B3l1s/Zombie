using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgrgarPuntaje : MonoBehaviour
{

    public int puntaje = 10;

    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Gamecontroler.Score += puntaje;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
