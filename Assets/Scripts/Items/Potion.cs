using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.E) && IsActiveNow && !pickedup && GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().coins >=3)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().coins -= 3;       
                Debug.Log(gameObject.name);
            pickedup = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().speed+=new Vector2(2,2);
            Destroy(gameObject);
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
