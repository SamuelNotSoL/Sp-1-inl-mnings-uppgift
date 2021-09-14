using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    GameObject followTarget;
    private Vector3 offset = new Vector3(0f, 0f, -10f);

    public float smoothspeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        followTarget = GameObject.Find("Player");
        print(followTarget.name);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = followTarget.transform.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(gameObject.transform.position, desiredPosition, smoothspeed * Time.deltaTime);
        gameObject.transform.position = smoothPosition;
    }
}
