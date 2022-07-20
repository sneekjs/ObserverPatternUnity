using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Vertical") * speed * Time.deltaTime, 0, -Input.GetAxis("Horizontal") * speed * Time.deltaTime);
    }
}
