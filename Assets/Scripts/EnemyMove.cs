using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float direction_switch_delay;
    public float speed;
    private float direction_timer;
    // Start is called before the first frame update
    void Start()
    {
        direction_timer = direction_switch_delay;
    }

    // Update is called once per frame
    void Update()
    {
        direction_timer -= Time.deltaTime;
        if (direction_timer < 0.0f)
        {
            speed *= -1;
            direction_timer = direction_switch_delay;
        }
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
