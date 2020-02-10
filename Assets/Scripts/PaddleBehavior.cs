using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    public float spd = 10;
    Vector3 vec = new Vector3(0, 0, 1);
    KeyCode downKey, upKey, shootKey;
    public GameObject Bullet;
    bool Gun = false;
    
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "RightPaddle") {
            downKey = KeyCode.DownArrow;
            upKey = KeyCode.UpArrow;
            shootKey = KeyCode.Space;
        }
        
        if (gameObject.tag == "LeftPaddle") {
            downKey = KeyCode.S;
            upKey = KeyCode.W;
            shootKey = KeyCode.F;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(downKey)) {
            transform.Translate(vec * -spd * Time.deltaTime);
        }
        
        if (Input.GetKey(upKey)) {
            transform.Translate(vec * spd * Time.deltaTime);
        }
        
        if (Input.GetKeyDown(shootKey) && Gun) {
            Instantiate(Bullet, gameObject.transform.position, new Quaternion()); 
        }
    }
    
    public void PowerUp(string Power) {
        if (Power == "Gun") {
            Gun = true;
        }
        
        if (Power == "Speed") {
            spd += 6;
        }
    }
}