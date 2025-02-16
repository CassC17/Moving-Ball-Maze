using UnityEngine;

public class Collision : MonoBehaviour
{
    public static float finalTime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            GameTimer.Instance.StopTimer();
            finalTime = GameTimer.Instance.elapsedTime;
            Debug.Log("Temps final : " + GameTimer.Instance.FormatTime(GameTimer.Instance.elapsedTime));

            Destroy(gameObject);
            SceneLoader.Instance.LoadSceneAfterDelay("GameScene", 1f);
        }

    }
}
