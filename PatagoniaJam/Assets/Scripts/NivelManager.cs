using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelManager : MonoBehaviour
{
    public float tiempoDeEspera;
    public bool hayDiapositivaTransicion = false;


    public void cambiarNivel(int indice)
    {
        StartCoroutine(CambioConEspera(indice));
    }

    private IEnumerator CambioConEspera(int indice)
    {
        if (hayDiapositivaTransicion)
        {
            DiapositivasManager diapositiva = FindObjectOfType<DiapositivasManager>();
            StartCoroutine(diapositiva.instanciateDiapositivas());
        }
        yield return new WaitForSeconds(tiempoDeEspera);
        SceneManager.LoadScene(indice);
    } 
}
