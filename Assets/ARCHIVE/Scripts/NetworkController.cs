using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkController : MonoBehaviourPunCallbacks {

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings(); // establishes connection to master server
	}

	public override void OnConnectedToMaster()
	{
		Debug.Log("We are now connected to the " + PhotonNetwork.CloudRegion + " server!");
		base.OnConnectedToMaster();
	}
}
