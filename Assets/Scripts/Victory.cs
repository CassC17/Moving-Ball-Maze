using TMPro;
using UnityEngine;


public class Victory : MonoBehaviour
{
    public TextMeshProUGUI finalTimeText;

    private void Start()
    {
        if (finalTimeText != null)
        {
            finalTimeText.text = FormatTime(Collision.finalTime);
        }
        else
        {
            Debug.LogWarning("finalTimeText n'est pas assigné !");
        }
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            Debug.Log("Victoire !");
            if (GameTimer.Instance != null)
            {
                GameTimer.Instance.StopTimer();
                Collision.finalTime = GameTimer.Instance.elapsedTime;
                Debug.Log(Collision.finalTime);
            }

            SceneLoader.Instance.LoadSceneAfterDelay("VictoryScene", 1f);
        }
    }

    
}


