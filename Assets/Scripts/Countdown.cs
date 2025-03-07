using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private float timeLimit;

    private float t = 0;

    private void Start()
    {
        t = timeLimit;
        UpdateTimerText(t);
    }

    private void Update()
    {
        t -= Time.deltaTime;

        if (t <= 0)
        {
            SceneManager.LoadScene("Result");
        }
        else
        {
            UpdateTimerText(t);
        }
    }

    private void UpdateTimerText(float time)
    {
        timerText.text = ((int)time).ToString();
    }
}
