using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartRoomDoor : MonoBehaviour
{

    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        LoadRandomEasyRoom();
    }

    void LoadRandomEasyRoom()
    {
        int index = Random.Range(4,7);
        SceneManager.LoadScene(index);
    }
    
}
