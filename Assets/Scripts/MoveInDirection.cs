using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInDirection : MonoBehaviour
{
    public Vector2 velocity;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GetGameActive())
        {
            transform.Translate(velocity * Time.deltaTime);
        }
    }
}
