using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorBasura : MonoBehaviour
{
    public static Action<int> OnContadorCambioEvent;

    public int contadorBasura = 0;
/*
    private void Start()
    {
        contadorBasura = 0;
    }
*/
    public void sumarContadorbasura()
    {
        contadorBasura++;
        OnContadorCambioEvent?.Invoke(contadorBasura);
    }
}
