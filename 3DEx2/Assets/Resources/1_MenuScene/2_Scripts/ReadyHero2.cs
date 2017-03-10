using UnityEngine;
using System.Collections;

public class ReadyHero2 : MonoBehaviour {
    public GameObject HeroCamera2;
    // Use this for initialization
    void Start () {
	
	}

    void Update()
    {

        transform.rotation = HeroCamera2.transform.rotation;

        Move();

    }
    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 3f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * 3f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 3f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 3f * Time.deltaTime);
        }
    }
}
