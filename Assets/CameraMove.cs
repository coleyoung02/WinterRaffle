using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Vector3 startPos;
    [SerializeField] private Transform target;
    [SerializeField] private Rigidbody wheel;
    private Vector3 targetPos;
    [SerializeField] private float startSpeed;
    private bool moveStarted;
    // Start is called before the first frame update
    void Start()
    {
        moveStarted = false;
        startPos = transform.position;
        targetPos = target.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            wheel.angularVelocity = new Vector3(0, 0, startSpeed);
            moveStarted = true;
        }
        if (moveStarted)
        {
            transform.position = Vector3.Lerp(targetPos, startPos, wheel.angularVelocity.z / startSpeed);
        }
    }
}
