using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NPCRoom : MonoBehaviour

{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("NPCRoom");
            collision.transform.position = new Vector2(0, -5);
        }

    }
}
