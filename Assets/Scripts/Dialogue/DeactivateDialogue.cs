using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateDialogue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Close());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Close() 
    {
        yield return new WaitForSeconds(3.2f);
        gameObject.SetActive(false);
    }
}
