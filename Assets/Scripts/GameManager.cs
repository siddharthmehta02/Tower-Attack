﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public GameObject spawnPoint;
    public GameObject[] enemies;
    public int maxEnemiesOnScreen;
    public int totalEnemies;
    public int enemiesPerSpwan;

    private int enemiesOnScreen = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy();
    }

    void spawnEnemy()
    {
        if(enemiesPerSpwan>0 && enemiesOnScreen < totalEnemies)
        {
            for(int i = 0; i < enemiesPerSpwan; i++)
            {
                if (enemiesOnScreen < maxEnemiesOnScreen)
                {
                    GameObject newEnemy = Instantiate(enemies[0]) as GameObject;
                    newEnemy.transform.position = spawnPoint.transform.position;
                    enemiesOnScreen += 1;
                }
            }
        }
    }
}
