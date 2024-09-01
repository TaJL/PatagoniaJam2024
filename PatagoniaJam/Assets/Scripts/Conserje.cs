using System;
using UnityEngine;

public class Conserje : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
    [SerializeField] private Transform _visual;

    private Rigidbody2D _rigidbody2D;
    private Vector3 _direction;
    private bool _canMove = true;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        DialogoManager.OnNewDialogoEvent += Frenar;
        DialogoManager.OnDialogoTerminoEvent += Continuar;
    }

    private void OnDisable()
    {
        DialogoManager.OnNewDialogoEvent -= Frenar;
        DialogoManager.OnDialogoTerminoEvent -= Continuar;
    }

    private void Frenar(DialogoData data)
    {
        _canMove = false;
    }

    private void Continuar()
    {
        _canMove = true;
    }

    void Update()
    {
        if (_canMove)
        {
            _direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            if (Vector3.Magnitude(_direction) > 0)
            {
                _direction.Normalize();
            }
        }
        else
            _direction = Vector3.zero;
        _rigidbody2D.velocity = _speed * _direction;
    }
}
