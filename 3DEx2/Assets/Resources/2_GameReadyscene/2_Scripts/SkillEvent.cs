using UnityEngine;
using System.Collections;

public class SkillEvent : MonoBehaviour
{
    public GameObject Sword;
    GameObject SkillPoint;
    public Animator SwordskillAni;

    // Use this for initialization
    void Start()
    {

        SkillPoint = GameObject.FindGameObjectWithTag("SwordSkillPoint");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Invoke("SwordSkill", 0.7f);
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            SwordskillAni.SetBool("SwordSkillbool", true);
        }
    }
    void SwordSkill()
    {

        GameObject SwordSkill = (GameObject)Instantiate(Sword, SkillPoint.transform.position, SkillPoint.transform.rotation);

    }

}