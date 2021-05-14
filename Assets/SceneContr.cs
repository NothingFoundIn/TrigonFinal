using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneContr : MonoBehaviour
{
    public GameObject obj;
    private bool gm = false;
    // переход по сценам _sceneNumber - сцена для перехода
    public void NextLvl(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
    // выход из приложения
    public void EndGame()
    {
        Application.Quit();
    }
    void Update()
    {
        if (Input.GetKeyDown("escape"))  // если нажата клавиша Esc (Escape)
        {
            if (gm)//если включено меню, то нажатие esc его выключает
            {
                obj.SetActive(false);
                Time.timeScale = 1;
                gm = !gm;
                return;
            }
            //если меню выключено включает меню при ecs
            gm = !gm;
            Time.timeScale = 0;
            obj.SetActive(true);
        }
    }
}
