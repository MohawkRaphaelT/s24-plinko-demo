using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOnTriggerEnter2D : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}
