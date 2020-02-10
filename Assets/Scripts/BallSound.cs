using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour
{
    [SerializeField] private AudioClip hitPaddle;
    [SerializeField] private AudioClip hitPaddleFast;
    [SerializeField] private AudioClip hitBullet;
    [SerializeField] private AudioClip hitPower;
    
    void OnCollisionEnter(Collision collider) {
        if (collider.gameObject.tag == "LeftPaddle" || collider.gameObject.tag == "RightPaddle") {
            if (gameObject.GetComponent<BallBehavior>().GetSpd() > 12) {
                gameObject.GetComponent<AudioSource>().PlayOneShot(hitPaddleFast);
            } else {
                gameObject.GetComponent<AudioSource>().PlayOneShot(hitPaddle);
            }
        }
        
        if (collider.gameObject.tag == "Bullet") {
            gameObject.GetComponent<AudioSource>().PlayOneShot(hitBullet);
        }
        
        if (collider.gameObject.tag == "PowerUp") {
            gameObject.GetComponent<AudioSource>().PlayOneShot(hitPower);
        }
    }
}
