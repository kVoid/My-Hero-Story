using UnityEngine;
using System.Collections;

public class Monster2 : MonoBehaviour {

    public GameObject Wepon;
    public GameObject HeroObj;
    public GameObject MonObj;
    public GameObject Bullet;
    public NavMeshAgent nav;
    public GameObject PlayerObj;
    public GameObject DarkSkill;
    public Animator MonsterAni;
    public int MonsterHp;
    int StartHp;
    public GameObject HpBar;
    static public bool MonAttackbool;
    // Use this for initialization

    public event System.Action OnDeath;

   void Start()
    {
        StartHp = MonsterHp;
        PlayerObj = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(UpdatePath());
        MonAttackbool = false;
    }
    void Update()
    {
        if(MonsterHp <= 0)
        {
            if(OnDeath != null)
            {
                OnDeath();
            }
            MonsterAni.SetBool("BcTankerDie", true);

        }
        
    }
    public void MonsterEnd()
    {
        GameObject.Destroy(MonObj);
    }
    public void MonsterAttackDone()
    {
        MonsterAni.SetBool("BcTankerAttack", false);
        MonAttackbool = false;
    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Bullet)
        {
            Destroy(Bullet);
            Debug.Log("hit");
            MonsterHp--;
        }
        if(other.gameObject == Wepon)
        {      
                MonsterHp--;
        }
        if (other.gameObject == DarkSkill)
        {
            MonsterHp-=10;
        }
        if(other.gameObject == HeroObj)
        {
            MonsterAni.SetBool("BcTankerAttack", true);
            MonAttackbool = true;
        }
        HpBar.gameObject.transform.localScale -= new Vector3( HpBar.gameObject.transform.localScale.x/StartHp , 0, 0);
    }
   
    IEnumerator UpdatePath()
    {
        float refreshRate = .25f;

        while (PlayerObj != null && Hero.HeroAlive == true)
        {
            Vector3 PlayerObjPos = new Vector3(PlayerObj.transform.position.x, 0, PlayerObj.transform.position.z);
            MonsterAni.SetBool("BcTankerWalk", true);
            nav.SetDestination(PlayerObjPos);
            yield return new WaitForSeconds(refreshRate);
        }
    }
}
