using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector2 pos;
    bool walk = true;
    int sign = -1;
    float idleTime = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (walk)
        {
            pos.x += (float) (sign * 0.05f);
            transform.position = pos;
            if (pos.x < 2.5 || pos.x > 8f)
            {
                walk = false;
                idleTime = 1.5f;
                GetComponent<Animator>().SetBool("walk", false);
            }
        }
        else
        {
            idleTime -= 0.02f;
            if (idleTime <= 0)
            {
                walk = true;
                GetComponent<SpriteRenderer>().flipX = (sign < 0);
                sign *= -1;
                GetComponent<Animator>().SetBool("walk", true);
            }
        }
    }
}
