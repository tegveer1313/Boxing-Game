using System.Collections.Generic;
using UnityEngine;

public class PlayerType : MonoBehaviour
{
    [System.Serializable]
    public class player
    {
        public Material material;
    }
    public SkinnedMeshRenderer renderer;
    public List<player> playersList;

    private void Awake()
    {
        renderer = GetComponent<SkinnedMeshRenderer>();
        CreatePlayer();

    }

    public void CreatePlayer()
    {
        int index = Random.Range(0, playersList.Count);
        //Debug.Log(index);
        renderer.material = playersList[index].material;
    }
}
