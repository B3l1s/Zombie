using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidas : MonoBehaviour
{
    private Slider Slider;


    private void Start()
    {
        Slider = GetComponent<Slider>();
    }
    public void CambiarVidamaxima(float VidaMaxima)
    {
        Slider.maxValue = VidaMaxima;
    }
    public void CambiarVidaActual(float CambiarVidaActual)
    {
        Slider.value = CambiarVidaActual;
    }
    public void InciarVida(float CantidadVida)
    {
        CambiarVidamaxima(CantidadVida);
        CambiarVidaActual(CantidadVida);
    }

}
