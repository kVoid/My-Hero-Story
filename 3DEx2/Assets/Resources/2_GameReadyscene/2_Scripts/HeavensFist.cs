using UnityEngine;
using System.Collections;

public class HeavensFist : MonoBehaviour
{
    public Animator FistskillAni;
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
        FistskillAni.SetBool("Skillbool", false);
    }
}

