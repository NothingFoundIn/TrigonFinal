using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trying : MonoBehaviour
{
    public GameObject gams;


    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Debug.Log("������");
            gams.SetActive(true);
        }
    }
    void OnTriggerExit(Collider col1)
    {
        if (col1.tag == "Player")
        {
            Debug.Log("��������");
            gams.SetActive(false);
        }
    }
}
