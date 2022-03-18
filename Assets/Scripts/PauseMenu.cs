using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] private GameObject PauseMenuUI;
    [SerializeField] private GameObject player;
    private bool isActive;
    private bool isPaused;


    // Update is called once per frame
    void Update()
    {
        if (isActive == false && Input.GetKeyDown(KeyCode.Escape))
        {
            IsActive();

        }

        else if (isActive == true && Input.GetKeyDown(KeyCode.Escape))
        {

            IsClosed();
        
        }
    }

    void IsActive()
    {
        PauseMenuUI.SetActive(true);
        isActive = true;
        Debug.Log("Opened");
        Time.timeScale = 0;
        player.GetComponent<PlayerController>().enabled = false;

    }

    public void IsClosed()
    {
        PauseMenuUI.SetActive(false);
        isActive = false;
        Debug.Log("Closed");
        Time.timeScale = 1;
        player.GetComponent<PlayerController>().enabled = true;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
