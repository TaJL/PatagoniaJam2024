using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelManager : MonoBehaviour
{
    public float tiempoDeEspera;

    public void cambiarNivel(int indice)
    {
        StartCoroutine(CambioConEspera(indice));
    }

    private IEnumerator CambioConEspera(int indice)
    {
        yield return new WaitForSeconds(tiempoDeEspera);
        SceneManager.LoadScene(indice);
    } 
}
