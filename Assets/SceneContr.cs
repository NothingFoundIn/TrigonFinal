using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneContr : MonoBehaviour
{
    public GameObject obj;
    private bool gm = false;
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
    void Update()
    {
        if (Input.GetKeyDown("escape"))  // ���� ������ ������� Esc (Escape)
        {
            if (gm)//���� �������� ����, �� ������� esc ��� ���������
            {
                obj.SetActive(false);
                Time.timeScale = 1;
                gm = !gm;
                return;
            }
            //���� ���� ��������� �������� ���� ��� ecs
            gm = !gm;
            Time.timeScale = 0;
            obj.SetActive(true);
        }
    }
}
