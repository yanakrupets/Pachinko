using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] Vector2 range;
    [SerializeField] GameObject coin;

    private float time = 3f;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        Debug.Log(time);
        yield return new WaitForSeconds(time);
        Vector2 coinPosition = transform.position + new Vector3(Random.Range(-range.y, range.y), 0);
        Instantiate(coin, coinPosition, Quaternion.identity);
        Repeate();
    }

    void Repeate()
    {
        StartCoroutine(Spawn());
        if (time >= 1f)
        {
            time -= 0.1f;
        }
    }
}
