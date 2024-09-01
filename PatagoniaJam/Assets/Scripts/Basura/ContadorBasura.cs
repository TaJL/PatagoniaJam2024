using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorBasura : MonoBehaviour
{
    public static Action<int> OnContadorCambioEvent;

    public int limiteNivel = 10;
    public int indiceNivel = 0;
    public int contadorBasura = 0;
    private NivelManager nivel;

    public void sumarContadorbasura()
    {
        contadorBasura++;
        if (contadorBasura == limiteNivel)
        {
            nivel = GetComponent<NivelManager>();
            nivel.cambiarNivel(indiceNivel);
        }
        OnContadorCambioEvent?.Invoke(contadorBasura);
    }
}
