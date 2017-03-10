using UnityEngine;
using System.Collections;

public class MonHand1 : MonoBehaviour {
    public GameObject HeroObj;
    public GameObject HeroHpBar;
	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("1");
        if(other.gameObject == HeroObj)
        {
            Debug.Log("2");
            if (Monster2.MonAttackbool == true)
            {
                Debug.Log("3");
                Hero.HeroHPNum -= 1;
                HeroHpBar.gameObject.transform.localScale -= new Vector3(HeroHpBar.gameObject.transform.localScale.x / Hero.StartHeroHPNum + HeroHpBar.gameObject.transform.localScale.x % Hero.StartHeroHPNum, 0, 0);
            }
        }
                
    }
}
