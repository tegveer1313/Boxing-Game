using UnityEngine;
using UnityEngine.SceneManagement;

public class JoinGame : MonoBehaviour
{
    public void OnJoinParctisMatch()
    {
        SceneManager.LoadScene("");
    }

    public void JoinMultiplayer()
    {
        SceneManager.LoadScene("Lobby");
    }
}
