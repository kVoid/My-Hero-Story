using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class HGameSceneBtn : MonoBehaviour {

    public void OnClick()
    {
        SceneManager.LoadScene("2_GameReadyscene");
    }
}
