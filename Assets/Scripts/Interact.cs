using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.E) && IsActiveNow && !pickedup)
        {
            Debug.Log(gameObject.name);
            pickedup = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsActiveNow = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        IsActiveNow = false;
    }
}