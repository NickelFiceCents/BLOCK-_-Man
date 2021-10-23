using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject playerPrefab;

    private void Start()
    {
        Vector3 SpawnPoint = new Vector3(-11, 3, -1);
        PhotonNetwork.Instantiate(playerPrefab.name, SpawnPoint, Quaternion.identity);
    }
}
