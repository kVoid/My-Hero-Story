using UnityEngine;
using System.Collections;

public class SwordSkillAct : MonoBehaviour
{
    public GameObject PlayerObj;
    public Animator SwordSkillAni;
    public bool SwordSkillbool;
    //public Collider MonCol;


    void Awake()
    {
        SwordSkillbool = false;
        PlayerObj = GameObject.FindGameObjectWithTag("Player");
       
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if(SwordSkillbool == true)
            {
                Debug.Log("sssssssss");
                SwordSkillAni.SetBool("Skillbool", true);
                SwordSkillbool = false;
            }
        }

    }
    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject == PlayerObj)
        {
            SwordSkillbool = true;
        }

    }

}
