using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camlookat : MonoBehaviour
{
    public Transform cam, player;

    void Update()
    {
        cam.LookAt(player);
    }
}
