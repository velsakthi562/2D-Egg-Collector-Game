using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject ombelet;
    public Transform dropOmbeletPosition;

    private GameManager manager;
    private AudioManager audioManager;

    void Start()
    {
        manager = FindObjectOfType<GameManager>();
        audioManager = FindObjectOfType<AudioManager>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            manager.ReduceLife();
            audioManager.PlayAudio(audioManager.eggCraking);
            Instantiate(ombelet, dropOmbeletPosition.position, ombelet.transform.rotation);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Basket"))
        {
            manager.Score += 10;
            audioManager.PlayAudio(audioManager.collectingEgg);
            Destroy(gameObject);
        }
    }
}
