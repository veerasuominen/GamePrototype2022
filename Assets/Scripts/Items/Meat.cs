using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    public bool IsActiveNow = false;
    public bool pickedup = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsActiveNow && !pickedup && GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().health < 6&& GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().coins >= 3)
        {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().health == 5)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().coins -= 3;
                Debug.Log(gameObject.name);
                pickedup = true;
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().health ++;
                Destroy(gameObject);
            }
            else
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().coins -= 3;
                Debug.Log(gameObject.name);
                pickedup = true;
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().health += 2;
                Destroy(gameObject);
            }
            
        }
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.name.Contains("Player"))
    //    {
    //        IsActiveNow = true;
    //    }

    //}
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    IsActiveNow = false;
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Player"))
        {
            IsActiveNow = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        IsActiveNow = false;
    }
}