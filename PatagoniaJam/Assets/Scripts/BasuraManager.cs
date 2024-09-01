using System.Collections;
using UnityEngine;

public class BasuraManager : MonoBehaviour
{
    [SerializeField] private Basura _basuraPrefab;
    [SerializeField] private Vector2 _areaDeSpawneo;
    [SerializeField] private int _contador;
    [SerializeField] private int _minEsperaSpawn;
    [SerializeField] private int _maxEsperaSpawn;

    private Conserje _conserje;

    private void Start()
    {
        _conserje = FindObjectOfType<Conserje>();
    }

    private IEnumerator SpawnBasuraCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(_minEsperaSpawn, _maxEsperaSpawn));
            SpawnBasura();
        }
    }

    private void SpawnBasura()
    {
        throw new System.NotImplementedException();
    }
}
