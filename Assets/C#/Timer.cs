using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerLeft = 3.0f;
    public bool start = false;
    public Text showTimer;

    public void timer()
    {
        timerLeft -= Time.deltaTime;
        showTimer.text = timerLeft.ToString("0");
        if (timerLeft <= 0)
        {
            showTimer.text = "Start";
        } 
    }
}
