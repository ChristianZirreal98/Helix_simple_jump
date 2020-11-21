using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformsMovement : MonoBehaviour
{
    [SerializeField] float MouseSentibilidade;
    
    // Update is called once per frame
    void Update()
    {
        
            float mouseX = Input.GetAxis("Mouse X") * MouseSentibilidade * Time.deltaTime;

            transform.Rotate(Vector3.up * mouseX);

        
        
    }
}
