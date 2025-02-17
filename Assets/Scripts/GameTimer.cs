using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public static GameTimer Instance;

    public float elapsedTime = 0f;
    public Text timerText;

    private bool isRunning = true;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    private void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime;

            if (timerText != null)
            {
                timerText.text = FormatTime(elapsedTime);
            }
        }
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
