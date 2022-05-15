using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class ItemRoomDoor : NetworkBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {            
            if (IsServer)
            {
                NetworkManager.Singleton.SceneManager.LoadScene("EasyRoomCleared", UnityEngine.SceneManagement.LoadSceneMode.Single);
                collision.transform.position = new Vector2(-7, 0);
            }
            else
            {
                SceneManager.LoadScene("EasyRoomCleared");
                collision.transform.position = new Vector2(-7, 0);
            }
        }

    }
}
