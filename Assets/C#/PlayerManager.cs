using UnityEngine;
using Photon.Pun;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    PlayerMotion playerMotion;
    PlayerType playerType;
    Timer timer;

    PhotonView photonView;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerMotion = GetComponent<PlayerMotion>();
        playerType = GetComponent<PlayerType>();
        timer = GetComponent<Timer>();
        photonView = GetComponent<PhotonView>();
    }

    public void Update()
    {
        if (photonView.IsMine)
        {
            inputManager.HandelAllMovement();
        }
    }

    private void FixedUpdate()
    {
        if (photonView.IsMine)
        {
          playerMotion.AllMovement();
        }
    }
}
