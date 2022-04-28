using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Enemy")==null)
        {
            ChangeSprite();
        }
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
