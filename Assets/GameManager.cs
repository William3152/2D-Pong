using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    //Buat UI Text
    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        //Mengisikan nilai integer PlayerScore ke UI
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
    }


    //Method penyeleksi untuk menambah score
    public void Score(string wallID)
    {
        if (wallID == "Line_Left")
        {
            PlayerScoreR += 10; //Menambah score
            txtPlayerScoreR.text = PlayerScoreR.ToString(); //Mengisikan nilai integer PlayerScore ke UI
        }
        else
        {
            PlayerScoreL += 10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();

        }
    }
    public void ScoreCheck()
    {
        if (PlayerScoreL == 20)
        {
            Debug.Log("playerL win");
            this.gameObject.SendMessage("ChangeScene", "GameOver");
            SceneManager.LoadScene("GameOver");
        }
        else if (PlayerScoreR == 20)
        {
            Debug.Log("playerR win");
            this.gameObject.SendMessage("ChangeScene", "GameOver");
            SceneManager.LoadScene("GameOver");
        }
    }
}