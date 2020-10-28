using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{

    public float speed;

    public GameManager manager;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
        

        if (manager.IsGameOver== false)
        {

            float hor = Input.GetAxis("Horizontal");

            if (transform.position.x <= 2f && hor > 0f)
            {
                transform.Translate(Vector3.right * hor * speed * Time.deltaTime);
            }
            else if (transform.position.x >= -2f && hor < 0f)
            {
                transform.Translate(Vector3.right * hor * speed * Time.deltaTime);
            }
        }

          
    }

}
