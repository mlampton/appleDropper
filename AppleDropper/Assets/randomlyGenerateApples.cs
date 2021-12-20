using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomlyGenerateApples : MonoBehaviour
{


    public GameObject apple;
    public Transform finish;
    public Transform start;
    private Transform target;

    private int timer = 500;
    public GameObject drop;


    // Start is called before the first frame update
    void Start()
    {
        target = start;


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        timer -= 1;

        if (timer == 0)
        {

            drop = Instantiate(apple);
            drop.GetComponentInChildren<Rigidbody2D>().gravityScale = 1;

            timer = 500;

        }




        float time = Mathf.PingPong(Time.time, 8);

        apple.transform.position = Vector2.MoveTowards(transform.position, target.position, 0.02f);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            if (target == start) { target = finish; }
            else target = start;

        }
    }

    
}
