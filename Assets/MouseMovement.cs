using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mouseSens = 100f;

    float rotX = 0f;
    float rotY = 0f;

    public float topClamp = -90f;
    public float bottomClamp = 90f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        rotX -= mouseY;

        rotX = Mathf.Clamp(rotX, topClamp, bottomClamp);

        rotY += mouseX;

        transform.localRotation = Quaternion.Euler(rotX, rotY, 0f);

    }
}
