using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Touch : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public int x;
    public int y;
    public int z;
    public GameObject gameObject;
    void OnMouseDown()
    {
        gameObject.transform.position = new Vector3(x, y, z);
        camera1.enabled = !camera1.enabled;
        camera2.enabled = !camera2.enabled;
    }
}
