using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGameMultiPlayer()
    {
        StartCoroutine(Startgame());
    }
    public void StartGameSinglePlayer()
    {
        SceneManager.LoadScene("StartSinglePlayer");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    IEnumerator Startgame()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("StartMultiPlayer2");
    }
}
