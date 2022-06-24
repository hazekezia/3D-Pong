using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text P1Score, P2Score, P3Score, P4Score;

    public ScoreManager Manager;
    
    private void Update(){
        P1Score.text = Manager.P1Score.ToString();
        P2Score.text = Manager.P2Score.ToString();
        P3Score.text = Manager.P3Score.ToString();
        P4Score.text = Manager.P4Score.ToString();
    }
}
