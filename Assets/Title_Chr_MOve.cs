using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.Rendering;
using UnityEngine;

public class Title_Chr_MOve : MonoBehaviour
{
    public bool IsTriggered = false;
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        //IsTriggered = false;
    }
    public void ToggleIsTriggered()
    { IsTriggered = !IsTriggered; } 
    // Update is called once per frame
    void Update()
    {
    
        if (IsTriggered)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
}
