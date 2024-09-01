using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Basura : MonoBehaviour
{
    [SerializeField, Min(0.1f)] private float _tiempoDeIntro = 0.3f;
    [SerializeField, Min(0.1f)] private float _tiempoParaLimpiar = 1f;
    [SerializeField] private SpriteRenderer _spriteRender;
    private float _tiempoRestante;
    private Rigidbody2D _conserje;
    private Collider2D _collider;

    private void Awake()
    {
        _tiempoRestante = _tiempoParaLimpiar;
        _collider = GetComponent<Collider2D>();
        _collider.enabled = false;
        if (_spriteRender != null)
        {
            Color color = _spriteRender.color;
            color.a = 0;
            _spriteRender.color = color;
            LeanTween.alpha(_spriteRender.gameObject, 1, _tiempoDeIntro).setOnComplete(context => _collider.enabled = true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Conserje conserje = other.GetComponent<Conserje>();
        if (conserje == null)
        {
            return;
        }
        _conserje = conserje.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Conserje conserje = other.GetComponent<Conserje>();
        if (conserje == null)
        {
            return;
        }
        if (_conserje == conserje.GetComponent<Rigidbody2D>())
        {
            _conserje = null;
        }
    }

    private void Update()
    {
        if (_conserje == null ||
            _conserje.velocity == Vector2.zero)
        {
            return;
        }

        _tiempoRestante -= Time.deltaTime;

        if (_spriteRender != null)
        {
            Color color = _spriteRender.color;
            color.a = 0.4f + 0.6f * _tiempoRestante/_tiempoParaLimpiar;
        }

        if (_tiempoRestante <= 0)
        {
            OnLimpiada();
        }
    }

    private void OnLimpiada()
    {
        ContadorBasura conserje = _conserje.GetComponent<ContadorBasura>();
        conserje.sumarContadorbasura();
        Destroy(gameObject);
    }
}