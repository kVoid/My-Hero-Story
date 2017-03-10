using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public float BulletSpeed = 1000.0f;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(transform.forward * BulletSpeed);
	}
	
}
