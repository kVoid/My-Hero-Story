using UnityEngine;
using System.Collections;

public class SwordSkill : MonoBehaviour
{
    public Animator SwordskillAni;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.O))
        //{
        //    SwordskillAni.SetBool("SwordSkillbool", true);
        //}
    }
    public void stop()
    {
        SwordskillAni.SetBool("Skillbool", false);
    }
}
