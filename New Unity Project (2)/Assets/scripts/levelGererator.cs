using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelGererator : MonoBehaviour
{
    [SerializeField] GameObject[] plataforms;
    int id;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, Random.Range(0, 360), 0);

        id = Random.Range(0, plataforms.Length);

        Instantiate(plataforms[id], transform.position, transform.rotation);
        
    }

    
}
