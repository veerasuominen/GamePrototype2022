using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class Player2Controller : NetworkBehaviour
{
    private Vector2 speed = new Vector2(5, 5);
    private int health = 6;
    private bool invincible;
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
        if (health == 0)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(this.gameObject);


    }

    void CharacterRotation()
    {
        if (Input.GetKey(KeyCode.A)&&IsClient)
        {
            if (Player != null)
            {
                // flip the sprite
                Player.flipX = false;
            }
        }
        if (Input.GetKey(KeyCode.D) && IsClient)
        {
            Player.flipX = true;
        }
        {

        }
    }

}
