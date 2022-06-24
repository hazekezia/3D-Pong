using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public int spawnInterval;
    public int ballCount;
    private float timer;
    public List<Vector3> spawnPoint;

    void Start(){
        timer = 0;   
    }

    void Update(){
        timer += Time.deltaTime;
        if (timer > spawnInterval){
            if (ballCount < 5){
                SpawnBall(spawnPoint[Random.Range(0, spawnPoint.Count)]);
                timer -= spawnInterval;
            }
        }
        
        
    }

    public void SpawnBall(Vector3 position){      
        Instantiate(ballPrefab, position, ballPrefab.transform.rotation);
        ballCount++;
    }
}
