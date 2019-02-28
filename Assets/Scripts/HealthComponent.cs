using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public float max_health;
    private float health;

    void Start()
    {
        health = max_health;
    }

    public void SetHealth (float init_health)
    {
        health = init_health;
    }

    public float GetHealth ()
    {
        return health;
    }

    public void Heal (float health_points)
    {
        if (health_points <= 0)
        {
            return;
        }
        health += health_points;
        if (health > max_health)
        {
            health = max_health;
        }
    } 

    public void TakeDamage (float damage)
    {
        if (damage <= 0)
        {
            return;
        }
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
