using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= 0.77)
        {
            transform.Translate(-0.1f * speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= 22.26)
        {
            transform.Translate( 0.1f * speed, 0, 0);
        }
    }
}
