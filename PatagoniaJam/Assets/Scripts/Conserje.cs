using UnityEngine;

public class Conserje : MonoBehaviour
{
    [SerializeField] private float _speed = 3;
    [SerializeField] private Transform _visual;

    private Rigidbody2D _rigidbody2D;
    private Vector3 _direction;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        if (Vector3.Magnitude(_direction) > 0)
        {
            _direction.Normalize();
        }
        _rigidbody2D.velocity = _speed * _direction;
    }
}
