using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basura : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Conserje conserje = other.GetComponent<Conserje>();
        if (conserje == null)
        {
            return;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Conserje conserje = other.GetComponent<Conserje>();
        if (conserje == null)
        {
            return;
        }
    }
}
