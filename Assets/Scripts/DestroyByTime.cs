using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    public float lifetime;

    private void Update()
    {
        if (lifetime - Time.deltaTime > 0)
        {
            lifetime -= Time.deltaTime;
        } else
        {
            Destroy(gameObject);
        }
    }
}
