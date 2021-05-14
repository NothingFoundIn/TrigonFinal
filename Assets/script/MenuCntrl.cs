using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuCntrl : MonoBehaviour
{
    public GameObject obj;
    public GameObject obj1;
    private bool gm = false;
    void Awake()
    {
        Time.timeScale = 1;
    }
    public void Cont()
    {
        gm = !gm;
        Time.timeScale = 1;
        obj.SetActive(false);
        obj1.SetActive(!obj1.activeSelf);
    }
    void Update()
    {
        if (Input.GetKeyDown("escape"))  // ���� ������ ������� Esc (Escape)
        {
            obj1.SetActive(!obj1.activeSelf);
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
