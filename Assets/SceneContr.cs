using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneContr : MonoBehaviour
{
    
    public void NextLvl(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
    public void EndGame()
    {
        Application.Quit();
    }
    void Update()
    {
        if (Input.GetKey("escape"))  // если нажата клавиша Esc (Escape)
        {
            Application.Quit();    // закрыть приложение
        }
    }
}
