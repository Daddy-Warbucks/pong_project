using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float spd;
    float spdTemp;
    Vector3 vec = new Vector3(1, 0, 1);
    Vector3 ballPos;
    public GameObject ScoreManager;
    GameObject lastHitPaddle;
    
    // Start is called before the first frame update
    void Start()
    {
        ballPos = gameObject.transform.position;
        spdTemp = spd;
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Translate(vec * spd * Time.deltaTime);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall") {
            vec.Set(vec.x, 0, -vec.z);
            spd += 1;
        }
        
        if (collision.gameObject.tag == "RightPaddle" || collision.gameObject.tag == "LeftPaddle") {
            vec.Set(-vec.x, 0, vec.z);
            spd += 1;
            lastHitPaddle = collision.gameObject;
        }
        
        if (collision.gameObject.tag == "Bullet") {
            vec.Set(-vec.x, 0, vec.z);
            spd += 1;
            Destroy(collision.gameObject);
        }
        
        if (collision.gameObject.tag == "LeftGoal" || collision.gameObject.tag == "RightGoal") {
            if (collision.gameObject.tag == "LeftGoal") {
                ScoreManager.GetComponent<ScoreManager>().IncrementScore2();
                vec.Set(-1, 0, 1);
            }
            if (collision.gameObject.tag == "RightGoal") {
                ScoreManager.GetComponent<ScoreManager>().IncrementScore1();
                vec.Set(1, 0, 1);
            }
            gameObject.transform.position = ballPos;
            spd = spdTemp;
        }
        
        if (collision.gameObject.tag == "PowerUp") {
            lastHitPaddle.GetComponent<PaddleBehavior>()
                .PowerUp(collision.gameObject.GetComponent<PowerUpBehavior>().GetPowerUp());
            Destroy(collision.gameObject);
        }
    }
    
    public float GetSpd() {
        return spd;
    }
}
