using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyEventDestroyOnEnd : MonoBehaviour
{
    [Header("Custom Event")]
    public UnityEvent myEvents;

    private void Start()
    {
        Object.Destroy(gameObject);
    }
}