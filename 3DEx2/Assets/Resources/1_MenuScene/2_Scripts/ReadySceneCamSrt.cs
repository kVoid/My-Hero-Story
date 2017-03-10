using UnityEngine;
using System.Collections;

public class ReadySceneCamSrt : MonoBehaviour
{
    public Animator CamAni;
    public static bool PlayerAniSrt;
    public static bool SwordSkillOnBool;
    // Use this for initialization
    void Start()
    {
        PlayerAniSrt = false;
        SwordSkillOnBool = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (BookLogoEnd.LogoSceneSrt == true)
        {
            CamAni.SetBool("CamOn", true);
        }
    }
    public void EndCamAni()
    {
        PlayerAniSrt = true;
    }
    public void SwordSkillOn()
    {
        SwordSkillOnBool = true;
    }


}
