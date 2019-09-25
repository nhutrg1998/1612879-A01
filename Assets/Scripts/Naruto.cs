using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Naruto : MonoBehaviour
{
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (pos.x > -8f) pos.x -= 0.3f;
                GetComponent<SpriteRenderer>().flipX = true;
            }
            else
            {
                if (pos.x < 8f) pos.x += 0.3f;
                GetComponent<SpriteRenderer>().flipX = false;
            }
            transform.position = pos;
            GetComponent<Animator>().SetBool("isRunning", true);
        }
        else
            GetComponent<Animator>().SetBool("isRunning", false);
    }
}
