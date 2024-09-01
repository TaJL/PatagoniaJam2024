using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiapositivasManager : MonoBehaviour
{
    public Sprite[] diapositivas;
    public int tiempoDeEspera = 1;
    public Image imagenDiapositiva;

    public IEnumerator instanciateDiapositivas()
    {
        imagenDiapositiva.enabled = true;
        if (diapositivas != null)
        {
            for (int i = 0; i < diapositivas.Length; i++)
            {
                imagenDiapositiva.sprite = diapositivas[i];
                yield return new WaitForSeconds(tiempoDeEspera);
            }
        }
    }
}
