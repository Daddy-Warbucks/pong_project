using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 dir;
    public float spd;
    
    void Start()
    {
        if (gameObject.transform.position.x < 0) {
            dir = new Vector3(1, 0, 0);
        } else {
            dir = new Vector3(-1, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * spd * Time.deltaTime);
        if (gameObject.transform.position.x > 18 || gameObject.transform.position.x < -18) {
            Destroy(gameObject);
        }
    }
}
