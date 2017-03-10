using UnityEngine;
using System.Collections;

public class PlayerOccupation : MonoBehaviour {
    public GameObject PlayerObj;
    int count;
	// Use this for initialization
	void Start () {
        PlayerObj = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == PlayerObj)
        {
            count++;
            Debug.Log(count);
        }
    }
    void OnTriggerExit(Collider other)
    {

    }
}
