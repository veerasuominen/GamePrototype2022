using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private static Music instance;

    void Awake()
    {
        if (Music.instance == null)
        {
            Music.instance = this;
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    void Start()
    {
    }

    public void turnMusicOff()
    {
    }

    void OnApplicationQuit()
    {
        Music.instance = null;
    }
}
