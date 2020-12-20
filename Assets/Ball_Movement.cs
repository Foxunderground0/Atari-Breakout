using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Movement : MonoBehaviour
{
    public float speed = 5f;
    public int Score = 0;
    public GameObject Score_text;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.tag != "Static")
        {
            Destroy(collision.gameObject);
            Score += 1;
            Score_text.GetComponent<TMPro.TextMeshProUGUI>().text = Score.ToString();
        }
        
    }
}
