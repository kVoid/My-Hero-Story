using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WinLogoAni : MonoBehaviour {

	public void WinLogoAniEnd()
    {
        SceneManager.LoadScene("1_Menuscene");
    }
}
