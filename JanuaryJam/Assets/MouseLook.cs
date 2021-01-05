using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float MouseSensitivity = 100f;
    public Transform PlayerBody; 
    float xRoataion = 0f;
    
    void Start() // Start is called before the first frame update
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update() // Update is called once per frame
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        xRoataion -= mouseY;
        xRoataion = Mathf.Clamp(xRoataion, -85f, 85f);
        transform.localRotation = Quaternion.Euler(xRoataion, 0f, 0f);
        //PlayerBody.Rotate(Vector2.up * mouseX); 
        PlayerBody.Rotate(Vector3.up *mouseX);
    }
}
