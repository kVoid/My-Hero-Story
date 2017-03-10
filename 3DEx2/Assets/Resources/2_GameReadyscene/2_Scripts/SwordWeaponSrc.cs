using UnityEngine;
using System.Collections;

public class SwordWeaponSrc : MonoBehaviour {

    public GameObject Player;
    public GameObject Activer;
    public GameObject Weapon;
    public GameObject PlayerWeaponPoint;

    Vector3 forceDirectoin;
    bool isPlayerEnter;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.F) && isPlayerEnter)
        {
            Debug.Log("Weapon!");
            Weapon.transform.SetParent(PlayerWeaponPoint.transform);
            Weapon.transform.localPosition = new Vector3(0,0,-38);
            Weapon.transform.localRotation = Quaternion.Euler(0  , -90, -90);

            isPlayerEnter = false;

        }
	}
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("On");
        if (other.gameObject == Player)
        {
            isPlayerEnter = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Off");
        if (other.gameObject == Player)
        {
            isPlayerEnter = false;
        }
    }
}
