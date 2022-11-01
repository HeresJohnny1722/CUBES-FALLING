using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksFalling : MonoBehaviour
{

    float speed = 7;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.Self);
    }
}
