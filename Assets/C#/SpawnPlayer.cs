using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject playerPrefab;
    public float minX;
    public float maxX;
    public float Y;
    public float minZ;
    public float maxZ;

    private void Start()
    {
        Vector3 randomPosition = new Vector3 (Random.Range(minX, maxX), Y, Random.Range(minZ, maxZ));

        PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
    }
}
