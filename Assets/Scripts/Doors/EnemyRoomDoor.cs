using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyRoomDoor : MonoBehaviour
{
    private void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player"&&gameObject.GetComponent<DoorOpen>().isOpen)
        {
            LoadRandomEasyRoom();
            collision.transform.position = new Vector2(7, 0);
        }
        
    }

    void LoadRandomEasyRoom()
    {
        int index = Random.Range(7, 10);
        SceneManager.LoadScene(index);
    }
}
