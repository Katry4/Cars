using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerStuff : NetworkBehaviour{

    public UnityStandardAssets.Characters.FirstPerson.FirstPersonController player;
    public CharacterController playerController;

    public Camera FPSCam;
    public AudioListener audioListener;


	// Use this for initialization
	void Start () {
		GameObject.Find("SceneCamera").SetActive(false);
		if (isLocalPlayer){
            player.enabled = true;
            playerController.enabled = true;
            FPSCam.enabled = true;
            audioListener.enabled = true;
        }
        else
        {
            player.enabled = false;
            playerController.enabled = false;
            FPSCam.enabled = false;
            audioListener.enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
