using UnityEngine;
using System.Collections;

public class DragonStrikeOn : MonoBehaviour {
    public Animator DragonSkr;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        

	}
    public void stop()
    {
        DragonSkr.SetBool("Skillbool", false);
    }
}


