using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketController : MonoBehaviour
{

    public Rigidbody2D player;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

        player = GetComponent<Rigidbody2D>();

        /*
         * Upon start we will also need to make 3 baskets as a column
         * We will have these as independent objects and call them by name
         * Destroying and collision detection happen in the apple controller script
         */ 

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        player.transform.Translate(h, 0, v);

        // add bounds 
        // in order to implement, we will need to call on a variable from the Camera Class
        /*
         * QUESTION: How do I import a variable from another script into this one? 
         * (i.e. important Camera variable from the cameraController script into the BasketController script)
         */
        // if (leftSideOfCameraView  || rightSideOfCameraView == player.position.x) { speed = 0f} else speed = 5; 
        // this would create+

        // Camera controller script defines the bounds of the camera, as well as makes it adaptable to the screen size
        // it seems the orthographic camera already adapts, is this correct?

    }

    
}
