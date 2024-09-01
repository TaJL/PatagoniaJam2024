using System;
using UnityEngine;

public enum EPersonaje
{
    Conserje = 0,
    OrcaRevelada = 1,
    OrcaMedioEscondida = 2,
    OrcaEscondida = 3,
}

[Serializable]
public struct BurbujaDialogoData
{
    public EPersonaje Emisor => _emisor;
    public string Mensaje => _mensaje;

    [SerializeField] private  EPersonaje _emisor;
    [SerializeField, TextAreaAttribute] private string _mensaje;
}
