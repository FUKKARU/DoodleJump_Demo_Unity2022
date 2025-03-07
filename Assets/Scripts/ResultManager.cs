using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI resultText;
    [SerializeField] private Button backButton;

    private void Start()
    {
        float score = PlayerPrefs.GetFloat("score");
        resultText.text = $"Score: {score:F2}m";

        backButton.onClick.AddListener(GoToTitleScene);
    }

    private void GoToTitleScene()
    {
        SceneManager.LoadScene("Title");
    }
}
