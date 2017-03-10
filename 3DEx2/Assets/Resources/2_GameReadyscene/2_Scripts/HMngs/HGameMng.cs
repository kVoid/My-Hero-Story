using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using MHomiLibrary;

public class HGameMng : HSingleton<HGameMng> {

    protected HGameMng() { }


    void Awake()
    {
        if (m_Instance == null)
            m_Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy()/HGameMng.cs");
    }
}
