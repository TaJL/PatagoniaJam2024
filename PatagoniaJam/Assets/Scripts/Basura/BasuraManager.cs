using System.Collections;
using UnityEngine;

public class BasuraManager : MonoBehaviour
{
    public GameObject[] objectsToInstantiate;
    public float x_min, y_min, x_max, y_max;
    public float spawn_time;
    public int spawn_max;
    private float period = 0.0f;
    private int cant_spwn = 0;

    private void Update()
    {
        if (period > spawn_time && cant_spwn < spawn_max)
        {
            instatiateGarbage();
            period = 0.0f;
            cant_spwn++;
        }
        period += Time.deltaTime;
    }
    private void instatiateGarbage()
    {
        int n = Random.Range(0, objectsToInstantiate.Length);
        Instantiate(objectsToInstantiate[n], new Vector3(Random.Range(x_min, x_max), Random.Range(y_min, y_max), 0), objectsToInstantiate[n].transform.rotation);
    }
}
