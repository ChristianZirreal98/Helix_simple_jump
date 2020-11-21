using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisor : MonoBehaviour
{
    [SerializeField] GameObject Plataform;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(Plataform);

        }
    }

}
