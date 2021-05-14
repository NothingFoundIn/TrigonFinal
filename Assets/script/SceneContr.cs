using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneContr : MonoBehaviour
{
    
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
    
}
