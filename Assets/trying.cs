using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trying : MonoBehaviour
{
    public GameObject gams; // объект с которым происходит работа
    public int lvlgo; // уровень тригера
    private bool wngo = false; // Находится ли объект в зоне действия тригера при нажатии enter

    void Update()
    {
        if (Input.GetKey(KeyCode.X) && wngo)
        {
            Debug.Log("вы попали на "+ lvlgo);
        }

    }
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            gams.SetActive(true);
            wngo = true;
        }
    }
    void OnTriggerExit(Collider col1)
    {
        if (col1.tag == "Player")
        {
            gams.SetActive(false);
            wngo = false;
        }
    }
}
