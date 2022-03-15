using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float BulletSpeed = 20;
    public GameObject Bullet;
    Quaternion posUp = Quaternion.Euler(0, 0, 0);
    Quaternion posRight = Quaternion.Euler(0, 0, -90);
    Quaternion posDown = Quaternion.Euler(0, 0, -180);
    Quaternion posLeft = Quaternion.Euler(0, 0, -270);
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Instantiate(Bullet, transform.position, Bullet.transform.rotation=posUp );
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            Instantiate(Bullet, transform.position, Bullet.transform.rotation=posDown);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Instantiate(Bullet, transform.position, Bullet.transform.rotation=posRight );
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Instantiate(Bullet, transform.position, Bullet.transform.rotation =posLeft);
        }
    }
}
