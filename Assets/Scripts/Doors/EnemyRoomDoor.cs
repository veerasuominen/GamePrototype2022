using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class EnemyRoomDoor : NetworkBehaviour
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
        string sceneName = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(index));


        //if (IsServer)
        //{
        //    NetworkManager.Singleton.SceneManager.LoadScene(sceneName, UnityEngine.SceneManagement.LoadSceneMode.Single);
        //}

        //SceneManager.LoadScene(index);
    }
}
