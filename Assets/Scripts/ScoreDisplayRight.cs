using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayRight : MonoBehaviour
{
    public Text scoreRight;
    public GameObject ScoreManager;
    
    // Update is called once per frame
    void Update()
    {
        scoreRight.text = "" + ScoreManager.GetComponent<ScoreManager>().GetScore2();
    }
}
