using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    [SerializeField] private Button startButton;

    private void Start()
    {
        startButton.onClick.AddListener(GoToMainScene);
    }

    private void GoToMainScene()
    {
        SceneManager.LoadScene("Main");
    }
}
