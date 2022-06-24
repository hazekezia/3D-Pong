using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public bool P1, P2, P3, P4;
    public Collider Ball;
    public ScoreManager Manager;
    public SpawnManager spawnManager;

    private void OnTriggerEnter(Collider collision) {
        if (collision.CompareTag("ball")){
            if (P1 && Manager.P1Score < Manager.ScoreMax){
                Destroy(collision.gameObject);
                Manager.AddScoreP1(1);
                spawnManager.ballCount--;
                
            }
            else if (P2 && Manager.P2Score < Manager.ScoreMax){
                Destroy(collision.gameObject);
                Manager.AddScoreP2(1);
                spawnManager.ballCount--;
                
            }
            else if (P3 && Manager.P3Score < Manager.ScoreMax){
                Destroy(collision.gameObject);
                Manager.AddScoreP3(1);
                spawnManager.ballCount--;
                
            }
            else if (P4 && Manager.P4Score < Manager.ScoreMax){
                Destroy(collision.gameObject);
                Manager.AddScoreP4(1);
                spawnManager.ballCount--;
                
            }
        }
    }
}
