using UnityEngine;
using System.Collections;

public class ReadyHero : MonoBehaviour
{
    public Animator HeroAni;
    public GameObject HeroObj;
    public GameObject HeroCamera2;
    public Vector3 HeroCamera2Vec;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            transform.LookAt(HeroCamera2Vec);

            HeroAni.SetBool("HeroRun", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
            HeroAni.SetBool("HeroRun", false);
    }
}
