using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Shooting : NetworkBehaviour
{
    public float BulletSpeed = 20;
    public GameObject Bullet;
    public GameObject Bullet2;
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
        if (IsOwner)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                int bully = Random.Range(1, 3);
                if (bully == 1)
                {
                    Instantiate(Bullet, transform.position, Bullet.transform.rotation = posUp);
                }
                else
                {
                    Instantiate(Bullet2, transform.position, Bullet2.transform.rotation = posUp);
                }

            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {

                int bully = Random.Range(1, 3);
                if (bully == 1)
                {
                    Instantiate(Bullet, transform.position, Bullet.transform.rotation = posDown);
                }
                else
                {
                    Instantiate(Bullet2, transform.position, Bullet2.transform.rotation = posDown);
                }
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                int bully = Random.Range(1, 3);
                if (bully == 1)
                {
                    Instantiate(Bullet, transform.position, Bullet.transform.rotation = posRight);
                }
                else
                {
                    Instantiate(Bullet2, transform.position, Bullet2.transform.rotation = posRight);
                }
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                int bully = Random.Range(1, 3);
                if (bully == 1)
                {
                    Instantiate(Bullet, transform.position, Bullet.transform.rotation = posLeft);
                }
                else
                {
                    Instantiate(Bullet2, transform.position, Bullet2.transform.rotation = posLeft);
                }
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                int bully = Random.Range(1, 3);
                if (bully == 1)
                {
                    Instantiate(Bullet, transform.position, Bullet.transform.rotation = posUp);
                }
                else
                {
                    Instantiate(Bullet2, transform.position, Bullet2.transform.rotation = posUp);
                }

            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {

                int bully = Random.Range(1, 3);
                if (bully == 1)
                {
                    Instantiate(Bullet, transform.position, Bullet.transform.rotation = posDown);
                }
                else
                {
                    Instantiate(Bullet2, transform.position, Bullet2.transform.rotation = posDown);
                }
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                int bully = Random.Range(1, 3);
                if (bully == 1)
                {
                    Instantiate(Bullet, transform.position, Bullet.transform.rotation = posRight);
                }
                else
                {
                    Instantiate(Bullet2, transform.position, Bullet2.transform.rotation = posRight);
                }
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                int bully = Random.Range(1, 3);
                if (bully == 1)
                {
                    Instantiate(Bullet, transform.position, Bullet.transform.rotation = posLeft);
                }
                else
                {
                    Instantiate(Bullet2, transform.position, Bullet2.transform.rotation = posLeft);
                }
            }
        }
        
    }
}
