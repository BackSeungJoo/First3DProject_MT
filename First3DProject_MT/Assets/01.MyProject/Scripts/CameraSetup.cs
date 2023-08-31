using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Photon.Pun;

public class CameraSetup : MonoBehaviourPun
{
    public CharacterController characterController;

    public GameObject camera;

    public void IsLocalPlayer()
    {
        characterController.enabled = true;
        camera.SetActive(true);
    }
}

