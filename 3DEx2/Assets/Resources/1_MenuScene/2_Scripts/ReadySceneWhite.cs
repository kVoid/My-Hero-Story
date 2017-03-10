using UnityEngine;
using System.Collections;

public class ReadySceneWhite : MonoBehaviour {
    public GameObject ReadyWhite;
	// Use this for initialization
	public void whiteEnd()
    {
        Destroy(ReadyWhite);
        ReadySceneCamera.RotOn = true;
    }
}
