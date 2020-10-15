using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour
{
    public GameObject ombelet;
    public Transform dropOmbeletPosition;

    private GameManager manager;

    void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            manager.ReduceLife();
            Instantiate(ombelet, dropOmbeletPosition.position, ombelet.transform.rotation);
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Basket"))
        {
            manager.Score += 10;
            Destroy(gameObject);
        }
    }
}
