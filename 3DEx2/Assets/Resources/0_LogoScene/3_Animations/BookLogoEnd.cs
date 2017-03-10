using UnityEngine;
using System.Collections;

public class BookLogoEnd : MonoBehaviour {

    public static bool LogoSceneSrt;
	// Use this for initialization
	void Start () {
        LogoSceneSrt = false;

    }
	
	// Update is called once per frame
	void Update () {
        

    }
    public void SceneSrt()
    {
        LogoSceneSrt = true;
    }
}
