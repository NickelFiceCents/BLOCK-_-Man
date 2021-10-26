using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createRoom;
    public InputField joinRoom;
    public GameObject yooy;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createRoom.text);
        yooy.SetActive(true);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoom.text);
        yooy.SetActive(true);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
