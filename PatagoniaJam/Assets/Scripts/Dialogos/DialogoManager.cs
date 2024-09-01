using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogoManager : MonoBehaviour
{
    public static Action<DialogoData> OnNewDialogoEvent;

    [SerializeField] private DialogoData[] _dialogosActivadosPorBasura;
    [SerializeField] private GameObject _textBox;
    [SerializeField] private TextMeshProUGUI _texto;
    private DialogoData _dialogoActivo;
    private int _dialogoIndex;

    private void Awake()
    {
        _textBox.SetActive(false);
    }

    private void OnEnable()
    {
        ContadorBasura.OnContadorCambioEvent += CheckSiActivarDialogo;
    }

    private void OnDisable()
    {
        ContadorBasura.OnContadorCambioEvent -= CheckSiActivarDialogo;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            AvanzarDialogo();
        }
    }

    private void CheckSiActivarDialogo(int basuraRecogida)
    {
        foreach (DialogoData dialogo in _dialogosActivadosPorBasura)
        {
            if (dialogo.TieneBasuraNecesaria(basuraRecogida))
            {
                IniciarDialogo(dialogo);
            }
        }
    }

    private void IniciarDialogo(DialogoData dialogo)
    {
        _dialogoActivo = dialogo;
        _dialogoIndex = -1;
        _textBox.SetActive(true);
        AvanzarDialogo();
        OnNewDialogoEvent?.Invoke(dialogo);
    }

    private void AvanzarDialogo()
    {
        _dialogoIndex++;
        if (_dialogoIndex >= _dialogoActivo.GetLength())
        {
            TerminarDialogo();
            return;
        }
        _texto.text = _dialogoActivo.GetBurbuja(_dialogoIndex).Mensaje;
    }

    private void TerminarDialogo()
    {
        _textBox.SetActive(false);
    }
}