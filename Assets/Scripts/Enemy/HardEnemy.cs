using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardEnemy : MonoBehaviour
{
    public int health = 3;
    private Vector3 direction = new Vector3(0, -1, 0);
    [SerializeField] private int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (transform.position.y>=3)
        {
            direction = -direction;
        }
        if (transform.position.y  <=-3)
        {
            direction = -direction;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.parent.name.Contains("Pinecone"))
        {
            Destroy(collision.transform.parent.gameObject);
            health -= GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().damage;
        }
        else if (collision.transform.name.Contains("Player") && collision.transform.GetComponent<PlayerController>().invincible == false)
        {
            collision.transform.GetComponent<PlayerController>().invincible = true;
            collision.transform.GetComponent<PlayerController>().health--;

            StartCoroutine(LoseInvincibility());
        }
        IEnumerator LoseInvincibility()
        {
            yield return new WaitForSeconds(1.5F);
            collision.transform.GetComponent<PlayerController>().invincible = false;
        }
    }

}

