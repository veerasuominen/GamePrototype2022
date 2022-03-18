using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyRoomDoor : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        LoadRandomEasyRoom();
    }

    void LoadRandomEasyRoom()
    {
        int index = Random.Range(7, 10);
        SceneManager.LoadScene(index);
    }
}
