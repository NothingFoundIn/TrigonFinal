using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class trying : MonoBehaviour
{
    public GameObject gams; // ������ � ������� ���������� ������
    public GameObject gams1; // ������ � ������� ���������� ������
    public GameObject sound; //���� �����
    public int lvlgo; // ������� �������
    private bool wngo = false; // ��������� �� ������ � ���� �������� ������� ��� ������� enter

    void Update()
    {
        if (Input.GetKey(KeyCode.X) && wngo)
        {
            if (lvlgo == 2)
            {
                return;
            }
            Time.timeScale = 0;
            StartCoroutine(Skip());
            
        }

    }
    IEnumerator Skip()
    {
        sound.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(lvlgo);
    }
    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            if (lvlgo == 3)
            {
                gams1.SetActive(true);
                wngo = false;
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
