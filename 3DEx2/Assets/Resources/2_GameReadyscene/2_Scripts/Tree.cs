using UnityEngine;
using System.Collections;

public class Tree : MonoBehaviour {

    public GameObject SwordObj;
    public Animator TreeAni;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == SwordObj)
        {
            TreeAni.SetBool("TreeDieBool", true);
           
        }
    }

}
