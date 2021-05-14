using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextMas : MonoBehaviour
{
    
    public Text tex; // ������� ����� �� ������
    public GameObject tes; //object ������ ������
    public InputField inp; //���� ����� '������'

    private int num;//������� ��� ��������� �� ����� � �����
    private int tsk;//������� ��� �������
    private List<string> txt = new List<string>() { 
        "���������� �������, ������� �� ������ ��������� ��� ���������� \n*����� �������� ������*",
        "�����, � ����, � ����� ���-�� ���� ���� ������� �� �������� ������",
        "������ ���������� �� ��� ��� ������, ��� ��������� �� ����� �� ��� ��� ���� ���� =(",
        "�, ��� �� �� ��� ���� ����������� �������� �� ����? ��� ��������, ������� �������� ��� ����",
        "���� ������ ������ ��� ���-������������ ������� � ��� ���-�� ������� �����-����� ����.",
        "���? �� ������� ������ �� ����� �����? �� ����� �������� ��� ����",
        "������ � �����. ������� ��� ��� ����� ������� ������� �� ��� � ��� �������� ����� ����������",
        "�������� ������ '�������' �� ����� �������� �����. ��� ����� ������ \n<div></div>",
        "��� ������, ������ �� ����������, ����� ����� ����� �������� ������ ����������������",
        "���� ���������� ��� ��������� ������, � ���������������� ����� �������� ������ ������",
        "������ ���� ������ �������� \nstyle=\"height: 500px; width: 500px; background: indigo\"",
        "��-��!!! ��� ��� ������� �� ��������, ����� ��? ���?",
        "����� ����� ��������� ���-��� ���������... �� ������ �������� ����� � ���� ������",
        "�����, � ���",
        "�� ��� �� �� �������, �� �� ������ �������� \nHello world",
        "���, � ��� ��������� ��������, ����� ��������� � ������, �� ��� ���������",
        "������ \n<h1 style=\"color: white\">Hello world</h1> � ���� ����� ������ ��������, ��� ������ �� � �����.\n����� ��� �������",
        "��� �������! ������ ��� ����� �����.",
        "����� ��� �� �����, ���������� ����� � ��������? ��� �� ��� ��� ����������",
        "����, ��� � ��� ������ �� �����?",
        "�� ����� �� �����, � ���� �� ��������� �������! � ����� ������ �� ���������� ��������������, �����",
        "...",
        "������ ���� �����"
    };//������ ����� � ��������� ��� ����� � tex
    private List<string> task = new List<string>() {
        "<div></div>",
        "style=\"height: 500px; width: 500px; background: indigo\"",
        "Hello world",
        "<h1 style=\"color: white\">Hello world</h1>"
    };//������ ����� � ���������
    private bool ch1 = false;//��� ������� �������

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))//������� Z
        {
            if (tes.activeSelf)//���� ���� z, �� �� �������� ������
            {
                tex.text = "�������, ����� �� ������ ��� �������� ������������. ��� ���, ��� � � ������� ������ ������ \n" + task[tsk];
                return;
            }
            //������� ������� ������
            else
            {
                tex.text = txt[num];
                num++;
            }
            //'�������' �������
            if (num == 8 || num == 11 || num == 17 || num == 15)
            {
                tes.SetActive(true);//��������� ������ ������
            }
            else if (num == 22)
            {
                
            }
        }
    }
    public void ClickBtn()
    {
        string inpt = inp.text;//����� � ���� �����
        if (inpt.ToLower().Trim() == task[tsk].ToLower().Trim())//������ ��� ������� ����� � ����� �����. ����� ������ �� � ������ �������. �������� ������������ ������
        {
            tsk++;
            inp.text = "";
            ch1 = true;
            tes.SetActive(false);
            tex.text = "�������, ������� ������";
        }
        //����� ������������
        else{
            tex.text = "���-�� �� ��� � ������, �������� �������� "+ task[tsk] + " ��� ���, ���� ������������ =)";
        }
    }
}