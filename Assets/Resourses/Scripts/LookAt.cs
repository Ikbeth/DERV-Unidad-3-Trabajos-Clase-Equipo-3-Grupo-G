using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField]
    GameObject ObjetoMirar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = ObjetoMirar.transform.position;
        pos.y = 0;
        this.transform.LookAt(pos);
    }
}
