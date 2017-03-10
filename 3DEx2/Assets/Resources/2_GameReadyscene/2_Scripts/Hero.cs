using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Hero : MonoBehaviour
{
    public GameObject Player;
    public GameObject Sword;
    public GameObject MonsterObj;
    public Animator PlayerAni;
    public Animator SwordSkillani;
    public Animator DarkSkillAni;
    public GameObject DarkSkillobj;
    public Animator HeroDieCam;
    static public int HeroHPNum;
    static public int StartHeroHPNum;
    static public bool HeroAlive;

    public Vector3 shootingDegree;
    public TrailRenderer SwordTrail;
    public Vector3 HeroCamera2;

    Vector3 SwordVec;
    bool[] PlayerMovebool;

    bool ESkillon;
    void Start()
    {

        //SwordTrail.enabled = false;
        HeroHPNum = 10;
        StartHeroHPNum = HeroHPNum;
        HeroAlive = true;
    }



    void Update()
    {
        if (HeroAlive == true)
        {
            if (Input.GetKey(KeyCode.W))
            {

                transform.LookAt(HeroCamera2);

                PlayerAni.SetBool("HeroRun", true);
            }
            if (Input.GetKeyUp(KeyCode.W))
                PlayerAni.SetBool("HeroRun", false);
            if (Input.GetMouseButtonDown(0))
            {
                StopCoroutine("OffTrailRenderer");
                SwordTrail.enabled = true;

                PlayerAni.SetBool("HeroBcAttack", true);
            }
            if (Input.GetMouseButtonUp(0))
            {
                //(OffTrailRenderer());
                StartCoroutine("OffTrailRenderer");
                PlayerAni.SetBool("HeroBcAttack", false);
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                Vector3 SkillVec3 = new Vector3();
                SkillVec3.x = transform.position.x;
                SkillVec3.y = transform.position.y;
                SkillVec3.z = transform.position.z;
                DarkSkillobj.transform.position = SkillVec3;
                DarkSkillAni.SetBool("DarkSkillOn", true);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {

                HeroHPNum = 1000;
            }

                if (HeroHPNum <= 0 || MonsterSpawner.HeroWinBool == true)
            {
                HeroDieCam.SetBool("HeroDieCamON", true);
                HeroAlive = false;
            }
        }
    }


    //public void SkillEnd()
    //{
    //    if (ESkillon == true)
    //    {
    //        PlayerAni.SetBool("HeroSkillEon", false);
    //    }

    //}
    IEnumerator OffTrailRenderer()
    {
        yield return new WaitForSeconds(0.7f);
        SwordTrail.enabled = false;
    }
}
