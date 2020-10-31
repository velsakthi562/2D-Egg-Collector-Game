using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private GameManager manager;
    private AudioManager audioManager;

    public float speed;
    public bool isflipping = false;

    public float timer;
    public float[] randomTimer = { 0.2f, 0.4f, 0.6f, 1f, 1.5f, 2f, 3f};

    public GameObject egg;
    public Transform dropEggPosition;
    

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<GameManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioManager = FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.IsGameOver)
        {
            return;
        }

        timer = timer - Time.deltaTime;


        if (timer < 0f)
        {  
            int randomNumber = Random.Range(0, randomTimer.Length);
            timer = randomTimer[randomNumber];
            Debug.Log(timer);
            audioManager.PlayAudio(audioManager.dropEgg);
            Instantiate(egg, dropEggPosition.position, dropEggPosition.rotation);
        }
       
        //flip
        if (isflipping == false && transform.position.x < 2f)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (isflipping == false && transform.position.x >= 2f)
        {
            isflipping = true;
            spriteRenderer.flipX = isflipping;
        }

        if (isflipping == true && transform.position.x > -2f)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        else if (isflipping == true && transform.position.x <= -2f)
        {
            isflipping = false;
            spriteRenderer.flipX = isflipping;
        }

    }
}   