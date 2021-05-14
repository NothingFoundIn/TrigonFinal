using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trying : MonoBehaviour
{
    public GameObject gams; // объект с которым происходит работа
    public GameObject gams1; // объект с которым происходит работа
    public int lvlgo; // уровень тригера
    private bool wngo = false; // Находится ли объект в зоне действия тригера при нажатии enter

    void Update()
    {
        if (Input.GetKey(KeyCode.X) && wngo)
        {
            if (lvlgo == 2)
            {
                return;
            }
            SceneManager.LoadScene(lvlgo);
        }

    }
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            if (lvlgo == 3)
            {
                gams1.SetActive(true);
                wngo = true;
            }
            else
            {
                gams.SetActive(true);
                wngo = true;
            }
        }
    }
    void OnTriggerExit(Collider col1)
    {
        if (col1.tag == "Player")
        {
            if (lvlgo == 3)
            {
                gams1.SetActive(false);
                wngo = false;
            }
            else
            {
                gams.SetActive(false);
                wngo = false;
            }
        }
    }
}
