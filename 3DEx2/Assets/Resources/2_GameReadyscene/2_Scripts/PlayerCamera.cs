using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour
{
    public GameObject PlayerObj;
   

    public float offsetX = 0f;
    public float offsetY = 25f;
    public float offsetZ = -35f;
    public float CamFollowSpeed = 3.0f;

    Vector3 PlayerCamPos;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        



    }
    void LateUpdate()
    {
        PlayerCamPos.x = PlayerObj.transform.position.x + offsetX;
        PlayerCamPos.y = PlayerObj.transform.position.y + offsetY;
        PlayerCamPos.z = PlayerObj.transform.position.z + offsetZ;

        transform.position =Vector3.Lerp(transform.position,PlayerCamPos, CamFollowSpeed * Time.deltaTime);
    }
}
