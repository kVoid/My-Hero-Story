using UnityEngine;
using System.Collections;
using MHomiLibrary;

public class HMng : HSingleton<HMng>
{

    protected HMng() { }

    void Awake()
    {
        if (m_Instance == null)
            m_Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    void Update()
    {

    }

    void OnDestroy()
    {
        Debug.Log("OnDestroy()/HMng.cs");
    }
}
