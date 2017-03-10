using UnityEngine;
using System.Collections;

public class LogoHeroSrc : MonoBehaviour {
    public Animator HeroAni;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(ReadySceneCamSrt.PlayerAniSrt == true)
        {
            HeroAni.SetBool("HeroLogoAniON", true);
        }
	}
}
