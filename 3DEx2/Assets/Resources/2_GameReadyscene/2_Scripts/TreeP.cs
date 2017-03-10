using UnityEngine;
using System.Collections;

public class TreeP : MonoBehaviour {

    public GameObject TreeObj;

    public void TreeEnd()
    {
        Destroy(TreeObj);
    }
}
