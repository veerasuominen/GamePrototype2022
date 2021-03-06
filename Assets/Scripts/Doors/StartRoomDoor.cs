using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Netcode;

public class StartRoomDoor : NetworkBehaviour
{


    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            LoadRandomEasyRoom();
            collision.transform.position = new Vector2(-0.2f, -3f);
        }
    }

    void LoadRandomEasyRoom()
    {
        int index = Random.Range(4,7);
        string sceneName = System.IO.Path.GetFileNameWithoutExtension(SceneUtility.GetScenePathByBuildIndex(index));
        if (IsServer)
        {
            NetworkManager.Singleton.SceneManager.LoadScene(sceneName, UnityEngine.SceneManagement.LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene(index);
        }

    }
    public static T DeserializeData<T>(string path)
    {
        //this is the magic that deserializes the data so we can load it
        T data = default(T);

        if (File.Exists(path))
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                data = (T)formatter.Deserialize(fs);
                Debug.Log("Data read from " + path);
            }
            catch (SerializationException e)
            {
                Debug.LogError(e.Message);
            }
            finally
            {
                fs.Close();
            }
        }
        return data;
    }

}
