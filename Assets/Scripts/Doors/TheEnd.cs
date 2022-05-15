using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class TheEnd : NetworkBehaviour
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
            SceneManager.LoadScene("TheEnd");
            if (IsServer)
            {
                NetworkManager.Singleton.SceneManager.LoadScene("TheEnd", UnityEngine.SceneManagement.LoadSceneMode.Single);
            }
            else
            {
                SceneManager.LoadScene("TheEnd");
            }
        }

    }
}

