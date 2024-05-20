using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class DisableCamera : NetworkBehaviour
{
    public GameObject camera;
    void Start()
    {
        if (!isOwned)
        {
            camera.SetActive(false);
        }
    }
}//
