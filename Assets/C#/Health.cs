using UnityEngine;
using Photon.Pun;

public class Health : MonoBehaviourPunCallbacks, IPunObservable
{
    public float health = 10f;

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        //sync Health
        if (stream.IsWriting)
        {
            stream.SendNext(health);
        }
        else
        {
            //We are reading
            health = (float)stream.ReceiveNext();
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
