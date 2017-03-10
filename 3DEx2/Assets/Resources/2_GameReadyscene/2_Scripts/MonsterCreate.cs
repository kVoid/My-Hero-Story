using UnityEngine;
using System.Collections;

public class MonsterCreate : MonoBehaviour
{
    public GameObject MonSter;
    GameObject MonCreatePoint;
    GameObject Player;
    public Animator PlayerAni;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        MonCreatePoint = GameObject.FindGameObjectWithTag("MonCreatePoint");


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.K))
             MonCreate();
    }
    void MonCreate()
    {

        Instantiate(MonSter, MonCreatePoint.transform.position, MonCreatePoint.transform.rotation);
    }

}


