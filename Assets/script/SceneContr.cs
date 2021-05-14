using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneContr : MonoBehaviour
{
    
    // ������� �� ������ _sceneNumber - ����� ��� ��������
    public void NextLvl(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
    // ����� �� ����������
    public void EndGame()
    {
        Application.Quit();
    }
    
}
