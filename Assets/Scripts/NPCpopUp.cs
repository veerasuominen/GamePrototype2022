using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCpopUp : MonoBehaviour
{

    [SerializeField] private bool isActive;
    public GameObject textBox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name.Contains("Player"))

        {
            textBox.SetActive(true); 
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.name.Contains("Player"))
        {
            textBox.SetActive(false); 
        }
    }

    /*
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("In Range");
    }*/



    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        isActive = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isActive = false;
    }*/
}

