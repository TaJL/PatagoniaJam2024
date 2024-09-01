using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NivelManager : MonoBehaviour
{
    public void cambiarNivel(int indice)
    {
        SceneManager.LoadScene(indice);
    }
}
