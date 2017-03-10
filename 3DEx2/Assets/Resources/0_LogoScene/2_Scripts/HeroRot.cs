using UnityEngine;
using System.Collections;

public class HeroRot : MonoBehaviour {
    public GameObject HeroCamera2;
    public Rigidbody PlayerRigidBody;
    public float PlayerSpeed;
    public float PlayerRotateSpeed;
    Vector3 HeroRotVec;
    Vector3 PlayerbodyVec;
    float HorizontalMove;
    float VerticalMove;
    // Use this for initialization
    void Awake()
    {
        PlayerRigidBody = GetComponent<Rigidbody>();
    }

    void Start ()
    {
        PlayerRotateSpeed = 1.0f;
        PlayerSpeed = 3.0f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Hero.HeroAlive == true)
        {
            transform.rotation = HeroCamera2.transform.rotation;

            Move();
        }
    }

    void Move()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * 3f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back* 3f * Time.deltaTime);
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

    //void FixedUpdate()
    //{
    //    HorizontalMove = Input.GetAxisRaw("Horizontal");
    //    VerticalMove = Input.GetAxisRaw("Vertical");

    //    Run(HorizontalMove, VerticalMove);
    //    //Turn();

    //}



    //void Run(float HorizontalMove, float VerticalMove)
    //{

    //    PlayerbodyVec.Set(HorizontalMove, 0, VerticalMove);
    //    PlayerbodyVec = PlayerbodyVec.normalized * PlayerSpeed * Time.deltaTime;

    //    //PlayerRigidBody.MovePosition(transform.position + PlayerbodyVec + transform.eulerAngles.normalized);
    //    PlayerRigidBody.MovePosition(transform.position + PlayerbodyVec);
    //}



    //void Turn()
    //{
    //    if (HorizontalMove == 0 && VerticalMove == 0)
    //        return;
    //    Quaternion newRotation = Quaternion.LookRotation(PlayerbodyVec);
    //    PlayerRigidBody.rotation = Quaternion.Slerp(PlayerRigidBody.rotation, newRotation, PlayerRotateSpeed * Time.deltaTime);
    //}



}
