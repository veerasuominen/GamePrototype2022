using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    public string textValue;
    public Text textElement;
    public int coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().coins;
        textElement.text = coins + "";
    }
}
