using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleGenerator : MonoBehaviour
{

    public GameObject apple;
    public Transform finish;
    public Transform start;
    private Transform target;

    private int timer = 1000;
    public GameObject drop;



    // Start is called before the first frame update
    void Start()
    {
        target = start;

    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1;

        if (timer == 0)
        {

            drop = Instantiate(apple);
            apple.GetComponentInChildren<Rigidbody2D>().gravityScale = 1;

            timer = 1000;

        }



        float time = Mathf.PingPong(Time.time, 8);

        //apple.transform.localPosition -= increaseValues;
        apple.transform.position = Vector2.MoveTowards(transform.position, target.position, 0.01f);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            if (target == start) { target = finish; }
            else target = start;

        }
    }
}
