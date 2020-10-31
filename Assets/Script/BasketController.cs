using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketController : MonoBehaviour
{
    public float speed;

    public GameManager manager;

    private Vector2 startPoint = Vector2.zero;
    private Vector2 currentPoint = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR

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
#elif UNITY_ANDROID

        Touch touch = Input.GetTouch(0);

        switch (touch.phase)
        {
            case TouchPhase.Began:
                startPoint = touch.position;
                break;
            case TouchPhase.Moved:
                currentPoint = touch.position;
                if(startPoint.x > currentPoint.x && transform.position.x >= -2f)
                {
                    float hor = startPoint.x - currentPoint.x;
                    transform.Translate(Vector2.left * (hor/10) * speed * Time.deltaTime);
                }
                else if (startPoint.x < currentPoint.x && transform.position.x < 2f)
                {
                    float hor = currentPoint.x - startPoint.x;
                    transform.Translate(Vector2.right * (hor/10) * speed * Time.deltaTime);
                }
                startPoint = currentPoint;
                break;
           
            case TouchPhase.Ended:
                startPoint = Vector2.zero;
                currentPoint = Vector2.zero;
                break;     
        }
#endif
    }

}
