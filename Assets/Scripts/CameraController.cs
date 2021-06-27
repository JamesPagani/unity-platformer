using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;

    public bool isInverted;

    //The camera's offset.
    private Vector3 offset = new Vector3(0, 1.25f, -6.25f);

    //The rotation applied with the mouse
    private float horizontalRotation;
    private float verticalRotation;
    private float vRotationModifier;
    private Quaternion rotation;
    private float verticalRotationMax = 45f;
    private float verticalRotationMin = 0f;

    private void Start()
    {
        isInverted = PlayerPrefs.GetInt("yInverted", 0) == 1;
    }

    //Camera controls.
    private void Update()
    {
        // Inverts the rotation.
        vRotationModifier = isInverted ? -1 : 1;

        // Pressing the RIGHT click will allow you to move the camera.
        if (Input.GetMouseButton(1))
        {
            //Horizontal rotation.
            horizontalRotation += Input.GetAxis("Mouse X");

            //Vertical rotation, which requires clamping.
            verticalRotation += Input.GetAxis("Mouse Y") * vRotationModifier;
        }
        verticalRotation = Mathf.Clamp(verticalRotation, verticalRotationMin, verticalRotationMax);
    }

    //Camera movement.
    void LateUpdate()
    {
        if (player.position.y - offset.y <= -30)
            CameraReset();
        rotation = Quaternion.Euler(verticalRotation, horizontalRotation, 0f);
        transform.position = player.transform.position + rotation * offset;
        transform.LookAt(player);
    }


    //Reset the camera.
    private void CameraReset()
    {
        verticalRotation = 0f;
        horizontalRotation = 0f;
    }
}
