using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleMouseButtons : MonoBehaviour
{
    [SerializeField]
    bool[] botones_mouse;
    // Start is called before the first frame update
    void Awake()
    {
        botones_mouse = new bool[7];
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < botones_mouse.Length; i++)
        {
            botones_mouse[i] = Input.GetKey("mouse " + i);
        }
    }
}
