using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
     Image image;
    [SerializeField] Sprite[] sprites;
    [SerializeField] GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (Player.GetComponent<PlayerController>().health == 6)
        {
            image.sprite = sprites[6];
        }
        if (Player.GetComponent<PlayerController>().health == 5)
        {
            image.sprite = sprites[5];
        }
        if (Player.GetComponent<PlayerController>().health == 4)
        {
            image.sprite = sprites[4];
        }
        if (Player.GetComponent<PlayerController>().health == 3)
        {
            image.sprite = sprites[3];
        }
        if (Player.GetComponent<PlayerController>().health == 2)
        {
            image.sprite = sprites[2];
        }
        if (Player.GetComponent<PlayerController>().health == 1)
        {
            image.sprite = sprites[1];
        }
        if (Player.GetComponent<PlayerController>().health == 0)
        {
            image.sprite = sprites[0];
            StartCoroutine(Dead());

        }

        IEnumerator Dead()
        {
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(10);
        }
    }
}
