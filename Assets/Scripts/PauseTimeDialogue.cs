using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTimeDialogue : MonoBehaviour
{
    [SerializeField] private GameObject DialogueBoxCharacters;
    [SerializeField] private GameObject Scroll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogueBoxCharacters.activeInHierarchy)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = false;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Shooting>().enabled = false;
        }
        else
        {
            Scroll.gameObject.SetActive(true);
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().enabled = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<Shooting>().enabled = true;
        }
    }
}
