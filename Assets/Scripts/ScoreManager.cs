using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int P1Score, P2Score, P3Score, P4Score, ScoreMax;

    public GameObject Paddle1, Paddle2, Paddle3, Paddle4;

    public GameObject P1Keep, P2Keep, P3Keep, P4Keep;
    public GameOver gameOver;

    public void AddScoreP1(int increment){
        P1Score += increment;

        if (P1Score >= ScoreMax){
            P1Keep.GetComponent<Collider>().isTrigger=false;
            Paddle1.SetActive(false);
        }
    }

    public void AddScoreP2(int increment){
        P2Score += increment;

        if (P2Score >= ScoreMax){
            P2Keep.GetComponent<Collider>().isTrigger=false;
            Paddle2.SetActive(false);
        }
    }

    public void AddScoreP3(int increment){
        P3Score += increment;

        if (P3Score >= ScoreMax){
            P3Keep.GetComponent<Collider>().isTrigger=false;
            Paddle3.SetActive(false);
        }
    }

    public void AddScoreP4(int increment){
        P4Score += increment;

        if (P4Score >= ScoreMax){
            P4Keep.GetComponent<Collider>().isTrigger=false;
            Paddle4.SetActive(false);
        }
    }

    public void Update()
    {
        //P1 Win
        if (P2Score == ScoreMax && P3Score == ScoreMax && P4Score == ScoreMax){
            gameOver.Over();
            gameOver.Winner.text = "Pemenangnya adalah Red!";
        }
        //P2 Win
        else if (P1Score == ScoreMax && P3Score == ScoreMax && P4Score == ScoreMax){
            gameOver.Over();
            gameOver.Winner.text = "Pemenangnya adalah Blue!";
        }
        //P3 Win
        else if (P1Score == ScoreMax && P2Score == ScoreMax && P4Score == ScoreMax){
            gameOver.Over();
            gameOver.Winner.text = "Pemenangnya adalah Green!";
        }
        //P4 Win
        else if (P1Score == ScoreMax && P2Score == ScoreMax && P3Score == ScoreMax){
            gameOver.Over();
            gameOver.Winner.text = "Pemenangnya adalah Purple!";
        }
    }
}
