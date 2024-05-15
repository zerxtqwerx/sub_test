using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class Teleport : MonoBehaviour
{
    public Transform point;
    public Text text;
    private GameObject localPlayer;
    bool teleportIsAllowed = false;

    private void Start()
    {
        text.enabled = false;
    }

    private void Update()
    {
        if(teleportIsAllowed && Input.GetKeyDown(KeyCode.T))
        {
            UseTeleport();
        }
    }

    private void OnTriggerEnter()
    {
        text.enabled = true;
        teleportIsAllowed = true;
    }

    private void OnTriggerExit()
    {
        text.enabled = false;
        teleportIsAllowed = false;
    }

    public void UseTeleport()
    {
        if (teleportIsAllowed)
        {
            localPlayer = NetworkClient.localPlayer.gameObject;
            localPlayer.transform.position = point.position;
        }
    }
}
