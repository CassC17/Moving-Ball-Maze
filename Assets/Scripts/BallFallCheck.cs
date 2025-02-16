using UnityEngine;
using UnityEngine.SceneManagement;

public class BallFallCheck : MonoBehaviour
{
    // seuil
    public float fallThreshold = -10f;

    private void Update()
    {
        if (transform.position.y < fallThreshold)
        {          
            Destroy(gameObject);
            SceneManager.LoadScene("GameScene");
        }
    }
}
