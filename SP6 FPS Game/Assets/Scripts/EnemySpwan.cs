using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpwan : MonoBehaviour
{

    public GameObject enemy;
    public Transform enemy1Pos;
    public Transform enemy2Pos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Invoke("EnemySpawner", 0.5f);
            Destroy(gameObject, 10);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }

    }

    void EnemySpawner()
    {
        Debug.Log("EnemySpwans");
        Instantiate(enemy, enemy1Pos.position, enemy1Pos.rotation);
        Instantiate(enemy, enemy2Pos.position, enemy2Pos.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
