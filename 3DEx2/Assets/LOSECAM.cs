using UnityEngine;
using System.Collections;

public class LOSECAM : MonoBehaviour {
    public Animator LoseLogo;
	// Use this for initialization
	public void loselogoOn()
    {
        LoseLogo.SetBool("LOSELOGOON", true);
    }
}
