using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class NPCRoom : NetworkBehaviour

{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player"&&gameObject.GetComponent<DoorOpen>().isOpen)
        {
            SceneManager.LoadScene("NPCRoom");
            collision.transform.position = new Vector2(0, -3);
            if (IsServer)
            {
                NetworkManager.Singleton.SceneManager.LoadScene("NPCRoom", UnityEngine.SceneManagement.LoadSceneMode.Single);
                collision.transform.position = new Vector2(-0.2f, -3f);
            }
            else
            {
                SceneManager.LoadScene("NPCRoom");
                collision.transform.position = new Vector2(-0.2f, -3f);
            }
        }

    }
}
