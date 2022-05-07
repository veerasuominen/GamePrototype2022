using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public bool isOpen=false;


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
            isOpen = true;
            Destroy(GameObject.FindGameObjectWithTag("Bush"));
        }

        if (isOpen)
        {
            Destroy(GameObject.FindGameObjectWithTag("Bush"));
        }
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }
}
