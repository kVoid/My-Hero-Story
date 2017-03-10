using UnityEngine;
using System.Collections;

public class WaveCheck : MonoBehaviour
{
    public bool WaveStartbool;
    public GameObject HeroObj;
    public Animator CasleWallDoorAni;
    // Use this for initialization
    void Start()
    {
        WaveStartbool = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (WaveStartbool == true && MonsterSpawner.WaveStart == false)
        {
            CasleWallDoorAni.SetBool("DoorOn", false);

        }
    }
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("ddfdfdfdfdfdfdfdfdf");
        if (other.gameObject == HeroObj)
        {
            Debug.Log("ddfdfdfdfdfdfdfdfdf");
            if (WaveStartbool == false) // 안에서 밖으로 나갈때.
            {
                WaveStartbool = true; // 밖에있다.
                CasleWallDoorAni.SetBool("DoorOn", true); // 문이닫힌다.
                MonsterSpawner.WaveStart = true;
            }
            if (WaveStartbool == true && MonsterSpawner.WaveStart == false)
            {
                WaveStartbool = false;
            }
        }
    }
}
