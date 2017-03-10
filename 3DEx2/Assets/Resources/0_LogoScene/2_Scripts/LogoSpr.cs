using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LogoSpr : MonoBehaviour {
    public Animator WhiteSprAni;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(LogoSkillSrc.SkillAnilEndBool == true)
        {
            WhiteSprAni.SetBool("WhiteSprOn", true);
        }
	}
    void LogoSceneEnd()
    {
        Debug.Log("SceneEnd@!!!");
        SceneManager.LoadScene("1_Menuscene");
    }
}
