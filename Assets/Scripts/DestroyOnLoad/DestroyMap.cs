using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMap : MonoBehaviour
{
    private static DestroyMap instance;
    // Start is called before the first frame update
    void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("Map").Length==2)
        {
            Destroy(gameObject);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
