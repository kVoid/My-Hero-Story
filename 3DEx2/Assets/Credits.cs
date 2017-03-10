using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {
    public GameObject Hero;
    public Animator CreditOn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Hero )
        {
            CreditOn.SetBool("CreditOn", true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Hero)
        {
            CreditOn.SetBool("CreditOn", false);
        }
    }
}
