using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float minXClamp;
    public float maxXClamp;

    // Start is called before the first frame update
    private void LateUpdate()
    {
        if (player)
        {
            Vector3 cameraPos;

            cameraPos = transform.position;
            cameraPos.x = Mathf.Clamp(player.transform.position.x, minXClamp, maxXClamp);
            transform.position = cameraPos;
        }
    }
}
