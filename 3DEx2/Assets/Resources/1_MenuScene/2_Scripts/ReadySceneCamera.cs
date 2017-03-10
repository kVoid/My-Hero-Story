using UnityEngine;
using System.Collections;

public class ReadySceneCamera : MonoBehaviour
{
    public GameObject PlayerObj;


    public float offsetX = 0f;
    public float offsetY = 25f;
    public float offsetZ = -35f;
    public float CamFollowSpeed = 3.0f;

    public float Speed = 20.0f;

    public float RotSpeed = 1.0f;
    static public bool RotOn = false;
    Vector3 PlayerCamPos;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");

        H = H * Speed * Time.deltaTime;
        V = V * Speed * Time.deltaTime;

        transform.Translate(Vector3.right * H);
        transform.Translate(Vector3.forward * V);

        float MouseX = Input.GetAxis("Mouse X");
        if(RotOn == true)
            transform.Rotate(Vector3.up * RotSpeed * MouseX);


    }
    void LateUpdate()
    {
        PlayerCamPos.x = PlayerObj.transform.position.x + offsetX;
        PlayerCamPos.y = PlayerObj.transform.position.y + offsetY;
        PlayerCamPos.z = PlayerObj.transform.position.z + offsetZ;

        transform.position = Vector3.Lerp(transform.position, PlayerCamPos, CamFollowSpeed * Time.deltaTime);
    }
}

