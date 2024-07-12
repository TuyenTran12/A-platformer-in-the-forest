using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public Transform mainCamera;
    public Transform midBG;
    public Transform sideBG;
    public float length;

    // Update is called once per frame
    void Update()
    {
        if (mainCamera.position.x > midBG.position.x)
        {
            UpdateBackGroundPosition(Vector3.right);
        }
        else if (mainCamera.position.x < midBG.position.x)
        {
            UpdateBackGroundPosition(Vector3.left);
        }
    }
    void UpdateBackGroundPosition(Vector3 direction)
    {
        sideBG.position = midBG.position + direction * length;
        Transform temp = midBG;
        midBG = sideBG;
        sideBG = temp;
    }

}
