using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{

    private float moveSpeed = 10;
    public int direction = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.rotation == Quaternion.Euler(0, 0, 0) && direction == 0)
        {
            direction = 1;
        }
        else if (transform.rotation == Quaternion.Euler(0, 0, -90) && direction == 0)
        {
            direction = 2;
        }
        else if (transform.rotation == Quaternion.Euler(0, 0, -270) && direction == 0)
        {
            direction = 3;

        }
        else if (transform.rotation == Quaternion.Euler(0, 0, -180) && direction == 0)
        {
            direction = 4;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (direction == 1)
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        }
        else if (direction == 2)
        {
            transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
        }
        else if (direction == 3)
        {
            transform.position += new Vector3(0, -moveSpeed * Time.deltaTime, 0);
        }
        else if (direction == 4)
        {
            transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
        }
        //transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.transform.name.Contains("Player") && collision.transform.GetComponent<PlayerController>().invincible == false)
    //    {
    //        collision.transform.GetComponent<PlayerController>().health--;
    //        collision.transform.GetComponent<PlayerController>().invincible = true;
    //        Destroy(gameObject);
    //    }
    //    else if (collision.transform.name.Contains("Player"))
    //    {
    //        Destroy(gameObject);
    //    }
    //    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name.Contains("Player") && collision.transform.GetComponent<PlayerController>().invincible == false)
        {
            collision.transform.GetComponent<PlayerController>().health--;
            Destroy(gameObject);
            
        }
        else if (collision.transform.name.Contains("Player"))
        {
            Destroy(gameObject);
        }
        IEnumerator LoseInvincibility()
        {
            yield return new WaitForSeconds(1.5f);
            collision.transform.GetComponent<PlayerController>().invincible = false;
        }
    }
}
