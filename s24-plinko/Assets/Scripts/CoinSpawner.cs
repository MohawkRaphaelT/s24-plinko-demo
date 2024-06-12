using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = transform.position;
            Quaternion rotation = Quaternion.identity;
            Instantiate(coin, position, rotation);
        }
    }
}
