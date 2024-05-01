using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camlookat : MonoBehaviour
{
    public Transform cam, player;

    void Update()
    {
        cam.LookAt(player);
        transform.Rotate( 0, 180, 0 );
    }
}
