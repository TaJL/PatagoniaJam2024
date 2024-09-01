using System;
using UnityEngine;

public class OrcaVisualizador : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        if (_spriteRenderer != null)
        {
            Color color = _spriteRenderer.color;
            color.a = 0;
            _spriteRenderer.color = color;
        }
    }

    private void OnEnable()
    {
        DialogoManager.OnNewDialogoEvent += ActualizarTransparencia;
    }

    private void OnDisable()
    {
        DialogoManager.OnNewDialogoEvent -= ActualizarTransparencia;
    }

    private void ActualizarTransparencia(DialogoData data)
    {
        LeanTween.alpha(_spriteRenderer.gameObject, data.TransparenciaDeBallena, 2);
        LeanTween.scale(_spriteRenderer.gameObject, data.TransparenciaDeBallena * Vector3.one, 2);
    }
}
