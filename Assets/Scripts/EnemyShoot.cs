using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float SHOOT_DELAY;
    private float shoot_delay;
    private List<EnemyHandler> children;

    void Start ()
    {
        shoot_delay = SHOOT_DELAY;
        children = new List<EnemyHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.GetGameActive())
        {
            children.Clear();
            foreach (Transform child in transform)
            {
                children.Add(child.gameObject.GetComponent<EnemyHandler>());
            }
            shoot_delay -= Time.deltaTime;
            if (children.Count >= 1)
            {
                if (shoot_delay <= 0)
                {
                    children[Random.Range(0, children.Count)].Shoot();
                    shoot_delay = SHOOT_DELAY;
                }
            } else {
                GameManager.SetGameActive(false);    
            }
        }
    }
}
