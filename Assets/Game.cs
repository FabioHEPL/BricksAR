using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField]
    private LoseCondition loseCondition;

    [SerializeField]
    private WinCondition winCondition;

    private void OnEnable()
    {
        this.loseCondition.Fulfilled += LoseCondition_Fulfilled;
        this.winCondition.Fulfilled += WinCondition_FulFilled;
    } 

    private void OnDisable()
    {
        this.loseCondition.Fulfilled -= LoseCondition_Fulfilled;
        this.winCondition.Fulfilled -= WinCondition_FulFilled;
    }

    private void LoseCondition_Fulfilled()
    {
        SceneManager.LoadScene("Main Level");
    }

    private void WinCondition_FulFilled()
    {
        //   SceneManager.LoadScene("Main Level");
        Debug.Log("Win !");
    }
}
