using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class GameManager : MonoBehaviourPunCallbacks
{
    public GameObject player;
    [Space]
    public Transform spawnPoint;

    void Start()
    {
        // �÷��̾� ����
        GameObject _Player = PhotonNetwork.Instantiate(player.name, spawnPoint.position, Quaternion.identity);
        _Player.GetComponent<CameraSetup>().IsLocalPlayer();
    }

    
}

