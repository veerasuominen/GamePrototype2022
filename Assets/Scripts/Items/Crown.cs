using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.E) && IsActiveNow && !pickedup && GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().coins >= 3)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().coins -= 3;
            Debug.Log(gameObject.name);
            GameObject.FindGameObjectWithTag("Player").transform.GetChild(0).gameObject.SetActive(true);
            pickedup = true;
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