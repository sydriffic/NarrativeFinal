using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Title_Clouds_Right : MonoBehaviour
{
    public bool IsTriggered = false;
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
          IsTriggered = false;
}

    // Update is called once per frame
    void Update()
    {
        if (IsTriggered = true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
