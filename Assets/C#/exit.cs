using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    public void OnExit()
    {
        SceneManager.LoadScene("MainM");
    }
}
