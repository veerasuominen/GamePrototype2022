using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(GameObject.Find("Player"));
        Destroy(GameObject.Find("PauseMenuController"));
        Destroy(GameObject.Find("Canvas"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
