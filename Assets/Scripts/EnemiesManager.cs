using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    public Enemy[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = FindObjectsOfType<Enemy> ();
        //Escribir en consola el valor de los damagePoints del último elemento del array
        Debug.Log(enemies[enemies.Length-1].damagePoints);
        SetAllEnemiesDamagePointsTo(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetAllEnemiesDamagePointsTo(int value)
    {
        for (int i=0; i < enemies.Length; i++)
        {
            enemies[i].damagePoints = value;
        }
    }
}
