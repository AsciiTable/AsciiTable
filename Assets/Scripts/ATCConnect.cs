using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ATCConnect : MonoBehaviour {
	void Awake() {
		PhotonNetwork.AutomaticallySyncScene = true;
	}
	void Start() {
		ConnectAsATC();
	}
	public void ConnectAsATC() {
		if (PhotonNetwork.IsConnected)
		{
			PhotonNetwork.JoinRandomRoom();
		}
		else {
			PhotonNetwork.ConnectUsingSettings();
			PhotonNetwork.GameVersion = "ATCv1";
		}
	}
}
