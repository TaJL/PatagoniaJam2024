using System;
using UnityEngine;

public class ImagenesDialogo : ScriptableObject
{
    [SerializeField] private ImagenDialogo[] _imagenes = new ImagenDialogo[0];

    public Sprite GetSprite(EPersonaje personaje)
    {
        foreach (ImagenDialogo imagen in _imagenes)
        {
            if (imagen.Personaje == personaje)
            {
                return imagen.Sprite;
            }
        }
        return null;
    }
}

[Serializable]
public struct ImagenDialogo
{
    public EPersonaje Personaje => _personaje;
    public Sprite Sprite => _sprite;
    [SerializeField] private EPersonaje _personaje;
    [SerializeField] private Sprite _sprite;
}
