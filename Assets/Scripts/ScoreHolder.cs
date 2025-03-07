using UnityEngine;

public class ScoreHolder : MonoBehaviour
{
    private float score = 0;

    private void Update()
    {
        float currentY = transform.position.y;
        score = Mathf.Max(score, currentY);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetFloat("score", score);
    }
}
