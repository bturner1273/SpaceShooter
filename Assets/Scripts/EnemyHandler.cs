using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    private HealthComponent health;
    public float bullet_damage;
    public Transform[] bullet_spawn_locations;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<HealthComponent>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player Bullet"))
        {
            Destroy(collision.gameObject);
            health.TakeDamage(bullet_damage);
            GameManager.SetScore(GameManager.GetScore() + 5);
        }
    }

    public void Shoot ()
    {
        for (int i = 0; i < bullet_spawn_locations.Length; i++)
        {
            Instantiate(bullet, bullet_spawn_locations[i].position, Quaternion.identity);
        }
    }
}
