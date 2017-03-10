using UnityEngine;
using System.Collections;

public class AttackEvent : MonoBehaviour
{
    public GameObject AttackBall;
    GameObject Shootpoint;
    GameObject Player;
    public Animator PlayerAni;
    public Vector3 shootingDegree;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Shootpoint = GameObject.FindGameObjectWithTag("shotstartpoint");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Invoke("Attack", 0.5f);
        }
    }
    void Attack()
    {
        
        GameObject instantiem = (GameObject)Instantiate(AttackBall, Shootpoint.transform.position, Shootpoint.transform.rotation);
        Rigidbody rigidbody = instantiem.GetComponent<Rigidbody>();
        rigidbody.AddForce(shootingDegree * 10f, ForceMode.Impulse);
    }
    public void AttackDone()
    {
        PlayerAni.SetBool("Attackbool", false);
    }
    
}

