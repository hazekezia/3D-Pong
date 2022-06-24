using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject UI;
    public bool pause = false;
    public Text Winner;

    public void Over(){
        UI.SetActive(true);
        pause = true;
    }

    public void Replay(){
        UI.SetActive(false);
        pause = false;
        SceneManager.LoadScene("Game");
    }

    public void MainMenu(){
        UI.SetActive(false);
        pause = false;
        SceneManager.LoadScene("MainMenu");
    }
}
