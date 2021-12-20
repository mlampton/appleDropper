using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyOnTrigger : MonoBehaviour
{

    private int counter = 3;
    public GameObject one;
    public GameObject two;
    public GameObject three;


    public void loadlevel(string level)
    {
        SceneManager.LoadScene(level);

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("apple"))
        {
            counter -= 1;

            Destroy(col.gameObject);

            Debug.Log(counter);

            if (counter == 2)
            {
                Destroy(one);
            }
            if (counter == 1)
            {
                Destroy(two);
            }
            if (counter == 0)
            {
                Destroy(three);
                SceneManager.LoadScene("GameOver");
            }
        }


    }

            // Start is called before the first frame update
            void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
