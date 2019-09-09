using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameUI : MonoBehaviour
{
    [SerializeField]
    private Game game;

    private void Awake()
    {
        this.game = FindObjectOfType<Game>();
    }

    private void OnEnable()
    {
        this.game.Ended += Game_Ended;
    }

    private void OnDisable()
    {
        this.game.Ended -= Game_Ended;
    }

    private void Game_Ended(EndGame endGame)
    {
        this.GetComponent<Image>().enabled = true;

        this.transform.GetChild(0).gameObject.SetActive(true);
            
        if (endGame == EndGame.Victory)
        {
            this.transform.GetChild(0).GetComponent<Text>().text = "You win !";
        }
        else if (endGame == EndGame.Defeat)
        {
            this.transform.GetChild(0).GetComponent<Text>().text = "You lose !";
        }

        // disable image target
        FindObjectOfType<BallDynamics>().gameObject.SetActive(false);
        FindObjectOfType<Wall>().gameObject.SetActive(false);
        FindObjectOfType<Mimic>().gameObject.SetActive(false);
    }

    // Start is called b1efore the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
