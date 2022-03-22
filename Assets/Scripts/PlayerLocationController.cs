using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocationController : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        player.transform.position= new Vector2(-0.2f, -4f);
    }
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.position = new Vector2(-0.2f, -4f);
    }
}
