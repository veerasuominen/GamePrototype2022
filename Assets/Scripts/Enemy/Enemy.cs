using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        //if (GameObject.Find("Player") == null)
        //{
        //    StartCoroutine(Dead());
        //}
        IEnumerator Dead()
        {
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(10);
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
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //     if (collision.transform.name.Contains("Player") && collision.transform.GetComponent<PlayerController>().invincible == false)
    //    {
    //        collision.transform.GetComponent<PlayerController>().health--;
    //        collision.transform.GetComponent<PlayerController>().invincible = true;
    //    }
        

    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name.Contains("Pinecone"))
        {
            Destroy(collision.gameObject);
            health--;
        }
        else if (collision.transform.name.Contains("Player") && collision.transform.GetComponent<PlayerController>().invincible == false)
        {
            collision.transform.GetComponent<PlayerController>().health--;
            collision.transform.GetComponent<PlayerController>().invincible = true;
            StartCoroutine(LoseInvincibility());
        }
        IEnumerator LoseInvincibility()
        {
            yield return new WaitForSeconds(2);
            collision.transform.GetComponent<PlayerController>().invincible = false;
        }
    }

}
