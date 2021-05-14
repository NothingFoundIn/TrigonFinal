using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamObj : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public GameObject ob1;
    public GameObject ob2;
    public GameObject ob3;
    public GameObject ob4;
    public GameObject ob5;
    public GameObject ob6;
    public GameObject ob7;
    private bool swit = true;
    private bool oncl = true;
    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        ob1.SetActive(false);
        ob2.SetActive(false);
        ob3.SetActive(false);
        ob4.SetActive(false);
        ob5.SetActive(false);
        ob6.SetActive(false);
        ob7.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
            ob1.SetActive(false);
            ob2.SetActive(false);
            ob3.SetActive(false);
            ob4.SetActive(false);
            ob5.SetActive(false);
            ob6.SetActive(false);
            ob7.SetActive(false);

        }
        if (Input.GetKey("escape"))  // если нажата клавиша Esc (Escape)
        {
            Application.Quit();    // закрыть приложение
        }
    }
}
