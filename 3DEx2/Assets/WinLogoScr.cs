using UnityEngine;
using System.Collections;

public class WinLogoScr : MonoBehaviour
{

    public Animator WinLogoAni;

    public void WinCamEnd()
    {
        WinLogoAni.SetBool("WinLogoOn", true);
    }
}
