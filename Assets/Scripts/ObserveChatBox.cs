using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserveChatBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PhotonNetwork.SendRate = 20;
		PhotonNetwork.sendRateOnSerialize = 10;
	}

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) { 
	}
}
