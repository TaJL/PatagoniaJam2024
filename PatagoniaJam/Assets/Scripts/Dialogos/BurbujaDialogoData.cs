using System;
using UnityEngine;

public enum EPersonaje
{
    CONSERJE = 0,
    ORCA = 1,
}

[Serializable]
public struct BurbujaDialogoData
{
    public EPersonaje Emisor => _emisor;
    public string Mensaje => _mensaje;

    [SerializeField] private  EPersonaje _emisor;
    [SerializeField] private string _mensaje;
}
