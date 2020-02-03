using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject GameManager;
    int Score1 = 0;
    int Score2 = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Score1 > 10) {
            GameManager.GetComponent<GameManager>().EndGame(1);
            Score1 = 0;
            Score2 = 0;
        }
        
        if (Score2 > 10) {
            GameManager.GetComponent<GameManager>().EndGame(2);
            Score1 = 0;
            Score2 = 0;
        }
    }
    
    public void IncrementScore1() {
        Score1++;
        Debug.Log("Player 1 has scored!\nPlayer 1: " + Score1 + "        Player 2: " + Score2);
    }
    
    public void IncrementScore2() {
        Score2++;
        Debug.Log("Player 2 has scored!\nPlayer 1: " + Score1 + "        Player 2: " + Score2);
    }
}
