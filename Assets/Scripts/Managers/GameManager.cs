using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    UIManager ui;
    static private int score;
    static private bool gameActive;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        gameActive = true;
        ui = FindObjectOfType<UIManager>();
    }
    
    public static int GetScore ()
    {
        return score;
    }

    public static void SetScore (int initScore)
    {
        score = initScore;
    }

    public static bool GetGameActive ()
    {
        return gameActive;
    }

    public static void SetGameActive (bool initGameActive)
    {
        gameActive = initGameActive;
        if (!gameActive)
        {
            RemoveBulletsFromScene();
            RemoveExplosionsFromScene();
        }
    }
    
    private static void RemoveExplosionsFromScene()
    {
        GameObject[] explosions = GameObject.FindGameObjectsWithTag("Explosion");
        foreach (GameObject explosion in explosions)
        {
            Destroy(explosion);
        }
    }

    private static void RemoveBulletsFromScene()
    {
        GameObject[] player_bullets = GameObject.FindGameObjectsWithTag("Player Bullet");
        GameObject[] enemy_bullets = GameObject.FindGameObjectsWithTag("Enemy Bullet");
        foreach (GameObject bullet in player_bullets)
        {
            Destroy(bullet);
        }
        foreach (GameObject bullet in enemy_bullets)
        {
            Destroy(bullet);
        }
    }
}
