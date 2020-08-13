using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControler : MonoBehaviour
{
    private float sensibilidade = 80f;
    public Transform playerBody;
    float xRotation = 0f;
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        
        float mouseX = Input.GetAxis("Mouse X") * sensibilidade * Time.deltaTime * 2;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidade * Time.deltaTime;


        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -60f, 60f);//Trava nos 90 graus

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);//Muda o sentido em que o player está andando 
    }
}
