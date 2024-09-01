using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorBasura : MonoBehaviour
{
    public int contadorBasura;

    private void Start()
    {
        contadorBasura = 0;
    }
    public void sumarContadorbasura()
    {
        contadorBasura++;
    }
}
