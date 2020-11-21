using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour
{
    [SerializeField] float MouseSentibilidade;

    [SerializeField] Transform player_body;

    float xRotation = 0f;

     void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * MouseSentibilidade * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * MouseSentibilidade * Time.deltaTime;


        xRotation += mouseX;

        transform.localRotation = Quaternion.Euler(0f, xRotation, 0f);

        player_body.Rotate(Vector3.up * mouseX);

    }
}
