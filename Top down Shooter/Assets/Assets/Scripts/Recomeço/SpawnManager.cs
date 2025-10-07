using UnityEngine;

public class SpawnManager : MonoBehaviour
{                    
                    //Esse colchetes serve para fazer uma lista
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject enemy;

    //GameObject player;

    void Start()
    {
        /*if (player != null)
        {
           
        }*/
          InvokeRepeating("SpawnEnemies", 0.5f, 0.75f); 
        
    }


    void SpawnEnemies()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy,spawnPoints[index].position , Quaternion.identity);
    }
}
