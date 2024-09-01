using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class VisualFlipper : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Transform[] _assetsToFlip;
    [SerializeField] private bool _defaultMiraAIzquierda;
    private Rigidbody2D _rigidbody2D;

    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (_rigidbody2D.velocity.x > 0)
        {
            _spriteRenderer.flipX = _defaultMiraAIzquierda;
            foreach (Transform item in _assetsToFlip)
            {
                Vector3 localPosition = item.localPosition;
                localPosition.x = Mathf.Abs(localPosition.x);
                item.localPosition = localPosition;
            }
        }
        else if (_rigidbody2D.velocity.x < 0)
        {
            _spriteRenderer.flipX = !_defaultMiraAIzquierda;
            foreach (Transform item in _assetsToFlip)
            {
                Vector3 localPosition = item.localPosition;
                localPosition.x = -Mathf.Abs(localPosition.x);
                item.localPosition = localPosition;
            }
        }
    }
}
