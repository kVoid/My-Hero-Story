using UnityEngine;
using System.Collections;

public class DarkSkillSrc : MonoBehaviour {
    public Animator DarkSkillAni;
    public GameObject DarkSkillobj;
    void DarkSkillEnd()
    {
       
        DarkSkillAni.SetBool("DarkSkillOn", false );
    }
}
