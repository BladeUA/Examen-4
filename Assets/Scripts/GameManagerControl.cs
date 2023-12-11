using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManagerControl : MonoBehaviour
{
    public Text textPlayer1Score;
    public int currentPlayer1Score;
    public Text textPlayer2Score;
    public int currentPlayer2Score;
    public bool isWin;
    public Text textWinner;
    public GameObject objBlackImagePopUpWinner;
    public GameObject objPopUpWinner;

    // Start is called before the first frame update
    void Start()
    {

        UpdatePlayer1Score(0);
        UpdatePlayer2Score(0);
        objBlackImagePopUpWinner.gameObject.SetActive(true);
        objPopUpWinner.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdatePlayer1Score(int score)
    {
        currentPlayer1Score = currentPlayer1Score + score;
        textPlayer1Score.text = "PLAYER 1: " + currentPlayer1Score;
        if (currentPlayer1Score == 3)
        {
            isWin = false;
            AppearWinPopUp("Player 1");
        }
    }

    void AppearWinPopUp(string playerWinner)
    {
        textWinner.text = playerWinner + " is the winner";
        objPopUpWinner.gameObject.SetActive(false);
        objBlackImagePopUpWinner.gameObject.SetActive(false);
    }

    public void UpdatePlayer2Score(int score)
    {
        currentPlayer2Score = currentPlayer2Score + score;
        textPlayer2Score.text = "PLAYER 2: " + currentPlayer2Score;
        if (currentPlayer2Score == 3)
        {
            isWin = false;
            AppearWinPopUp("Player 2");
        }
    }
}