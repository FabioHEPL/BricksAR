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

    public event Action<EndGame> Ended;

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


    private void OnEnded(EndGame endGame)
    {
        this.Ended?.Invoke(endGame);
    }

    private void WinCondition_FulFilled()
    {                
        OnEnded(EndGame.Victory);
        this.LoadScene("AR Level", 5f);
    }

    private void LoseCondition_Fulfilled()
    {
        OnEnded(EndGame.Defeat);
        this.LoadScene("AR Level", 5f);
    }

    private void LoadScene(string name, float delay)
    {
        StartCoroutine(LoadScene_Coroutine(name, delay));
    }

    private IEnumerator LoadScene_Coroutine(string name, float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        SceneManager.LoadScene(name);
    }
}
