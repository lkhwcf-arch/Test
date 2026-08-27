using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{


    private void Update()
    {
        transform.Translate(new Vector3(1f, 3f, 2f) * Time.deltaTime);
    }

}
