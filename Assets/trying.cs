using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trying : MonoBehaviour
{
    public GameObject gams; // ������ � ������� ���������� ������
    public int lvlgo; // ������� �������
    private bool wngo = false; // ��������� �� ������ � ���� �������� ������� ��� ������� enter

    void Update()
    {
        if (Input.GetKey(KeyCode.X) && wngo)
        {
            Debug.Log("�� ������ �� "+ lvlgo);
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
