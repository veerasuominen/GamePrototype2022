using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField]private GameObject bullet;
    private float time = 0.0f;
    private float someSeconds = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time>=someSeconds)
        {
            time = time - someSeconds;
            Instantiate(bullet, transform.position+new Vector3(1,0,0), Quaternion.Euler(0, 0, 0));
        }
        
    }
}
