using UnityEngine;
using System.Collections;

public class GunScr : MonoBehaviour {
    public GameObject Bullet;
    public Transform ShotPoint;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Z))
        {
            CreateBullet();
        }

    }
    void CreateBullet()
    {
        Instantiate(Bullet, ShotPoint.position, ShotPoint.rotation);
    }
}
