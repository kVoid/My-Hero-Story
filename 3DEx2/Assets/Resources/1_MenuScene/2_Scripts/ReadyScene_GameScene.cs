using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReadyScene_GameScene : MonoBehaviour
{
    public GameObject HeroObj;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider Hero)
    {
        if(Hero.gameObject == HeroObj)
        {
            SceneManager.LoadScene("2_GameReadyscene");
        }
    }
}
