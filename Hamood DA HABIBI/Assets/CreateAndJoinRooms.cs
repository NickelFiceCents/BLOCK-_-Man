using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createRoom;
    public InputField joinRoom;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createRoom.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(joinRoom.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
    }
}
