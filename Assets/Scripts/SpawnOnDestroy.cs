using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnDestroy : MonoBehaviour
{
    public GameObject explosion;

    private void OnDestroy()
    {
        if (explosion)
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
        }   
    }
}
