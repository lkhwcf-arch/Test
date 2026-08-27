using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position  += new Vector3(1.0f, 0f, 0f);
    }
}
