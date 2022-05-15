using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class PlayerController : NetworkBehaviour
{
    public Vector2 speed = new Vector2(5, 5);
    public int health = 6;
    public bool invincible;
    public int coins;
    public int damage = 1;
    // variable to hold a reference to our SpriteRenderer component
    private SpriteRenderer Player;

    // This function is called just one time by Unity the moment the component loads
    private void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        Player = GetComponent<SpriteRenderer>();

    }
    // Update is called once per frame
    void Update()
    {
            float inputY = Input.GetAxis("Vertical");
            float inputX = Input.GetAxis("Horizontal");

            Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

            movement *= Time.deltaTime;

            transform.Translate(movement);

            CharacterRotation();
        if (health==0)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
        
    }

    void CharacterRotation()
    {
        if (IsOwner)
        {
            if (Input.GetKey(KeyCode.A) && IsOwner)
            {
                if (Player != null)
                {
                    // flip the sprite
                    Player.flipX = true;
                }
            }
            if (Input.GetKey(KeyCode.D) && IsOwner)
            {
                Player.flipX = false;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                if (Player != null)
                {
                    // flip the sprite
                    Player.flipX = true;
                }
            }
            if (Input.GetKey(KeyCode.D))
            {
                Player.flipX = false;
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name.Contains("Bullet")&&!invincible)
        {
            Destroy(collision.gameObject);
            health--;
        }
        else if (collision.transform.name.Contains("Bullet"))
        {
            Destroy(collision.gameObject);
        }
    }
}
