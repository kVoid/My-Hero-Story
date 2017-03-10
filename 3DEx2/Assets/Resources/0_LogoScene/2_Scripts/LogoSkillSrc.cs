using UnityEngine;
using System.Collections;

public class LogoSkillSrc : MonoBehaviour
{
    public Animator LogoSkillAni;
    public static bool SkillAnilEndBool;
    // Use this for initialization
    void Start()
    {
        SkillAnilEndBool = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ReadySceneCamSrt.SwordSkillOnBool == true)
        {
            LogoSkillAni.SetBool("LogoSkillOn", true);
        }

    }
    void SkillAniEnd()
    {
        SkillAnilEndBool = true;
    }
}

