using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreLeft;
    public GameObject ScoreManager;
    
    // Update is called once per frame
    void Update()
    {
        scoreLeft.text = "" + ScoreManager.GetComponent<ScoreManager>().GetScore1();
    }
}
