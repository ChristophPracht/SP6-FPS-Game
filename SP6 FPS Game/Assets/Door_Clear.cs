using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Clear : MonoBehaviour
{

    GameObject[] enemiesInTheScene;

    private void Start()
    {
        GameObject[] enemiesInTheScene = GameObject.FindGameObjectsWithTag("elvl1");
        Debug.Log(enemiesInTheScene[0]);
    }

    private void Update()
    {
        GameObject[] enemiesInTheScene = GameObject.FindGameObjectsWithTag("elvl1");

        if (enemiesInTheScene.Length == 0)
        {
            Debug.Log("elvl1 cleared");
            Destroy(gameObject);
        }

    }

}
