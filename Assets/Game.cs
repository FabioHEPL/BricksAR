using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField]
    private LoseCondition loseCondition;

    private void OnEnable()
    {
        this.loseCondition.Fulfilled += LoseCondition_Fulfilled;
    }

    private void OnDisable()
    {
        this.loseCondition.Fulfilled -= LoseCondition_Fulfilled;
    }

    private void LoseCondition_Fulfilled()
    {
        SceneManager.LoadScene("Main Level");
    }
    
}
