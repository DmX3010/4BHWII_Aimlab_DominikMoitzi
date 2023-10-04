using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public float mouseYspeed = 10;

    [Range(0f, 90f)]
    public float yRotaionLimit = 88f;
    private Vector2 cameraRotaion = Vector2.zero;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMouseInput = Input.GetAxis("Mouse Y");
        cameraRotaion.y += verticalMouseInput * mouseYspeed * Time.deltaTime * 60;
        cameraRotaion.y = Mathf.Clamp(cameraRotaion.y,-yRotaionLimit,yRotaionLimit);
        var yQuat = Quaternion.AngleAxis(cameraRotaion.y, Vector3.left);
        Camera.main.transform.localRotation = yQuat;
    }
}
