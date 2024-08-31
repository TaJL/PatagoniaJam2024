
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _maxX;
    [SerializeField, Min(1)] private float _factor = 1;
    private Transform _conserje;
    
    void Start()
    {
        Conserje conserje = FindObjectOfType<Conserje>();
        _conserje = conserje.transform;
    }

    void LateUpdate()
    {
        Vector3 newPosition = transform.position;
        float targetX = _conserje.transform.position.x/_factor;
        newPosition.x = Mathf.Clamp(targetX, -_maxX, _maxX);
        transform.position = newPosition;
    }
}
