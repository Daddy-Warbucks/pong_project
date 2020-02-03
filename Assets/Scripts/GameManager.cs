using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void EndGame(int winner) {
        if (winner == 1) {
            Debug.Log("Game Over, Left Paddle Wins");
        }
        
        if (winner == 2) {
            Debug.Log("Game Over, Right Paddle Wins");
        }
    }
}
