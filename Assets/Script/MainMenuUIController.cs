using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
    }
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Application.Quit();
    }
}
