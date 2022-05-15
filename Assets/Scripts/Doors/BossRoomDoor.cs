using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class BossRoomDoor : NetworkBehaviour
{
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
        if (collision.gameObject.tag == "Player")
        {
            if (IsServer)
            {
                NetworkManager.Singleton.SceneManager.LoadScene("BossRoom", UnityEngine.SceneManagement.LoadSceneMode.Single);
                collision.transform.position = new Vector2(-0.2f, -3f);
            }
            else
            {
                SceneManager.LoadScene("BossRoom");
                collision.transform.position = new Vector2(-0.2f, -3f);
            }
           
        }
    }
}
