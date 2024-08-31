using UnityEngine;

public class Orca : MonoBehaviour
{
    [SerializeField] private Transform _conserje;
    [SerializeField] private Vector3 _centroDeAcuario;
    [SerializeField] private float _acuarioAPisoRatio = 2;
    [SerializeField] private float _speed = 2;
    [SerializeField] private float _ruido = 0.5f;

    private Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 posicionObjetivo = _centroDeAcuario + new Vector3(_conserje.position.x, _acuarioAPisoRatio * _conserje.position.y);
        Vector2 direccionObjetivo = (posicionObjetivo - (Vector2)transform.position).normalized;
        Vector2 direccionRandomizada = direccionObjetivo + new Vector2(Random.Range(-_ruido, _ruido), Random.Range(_ruido, _ruido));
        direccionRandomizada.Normalize();
        _rigidbody2D.velocity += direccionRandomizada * Time.deltaTime;
        if (_rigidbody2D.velocity.magnitude > _speed)
        {
            _rigidbody2D.velocity = _speed * _rigidbody2D.velocity.normalized;
        }
    }
}
