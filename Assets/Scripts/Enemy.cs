using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    [SerializeField] Collider bullet;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    health--;
    //    if (other == player)
    //    {
    //        Destroy(player.gameObject);
    //    }
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name.Contains("Pinecone"))
        {
            health--;
            Destroy(collision.transform.gameObject);
        }
        else if (collision.transform.name.Contains("Player"))
        {
            Destroy(collision.transform.gameObject);
        }
       
    }
}
