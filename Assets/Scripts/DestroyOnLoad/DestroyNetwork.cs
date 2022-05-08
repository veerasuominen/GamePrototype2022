using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNetwork : MonoBehaviour
{
    private static DestroyNetwork instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (DestroyNetwork.instance == null)
        {
            DestroyNetwork.instance = this;
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
