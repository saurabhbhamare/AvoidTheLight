using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyPlayButton : MonoBehaviour
{
    public Button playButton;
    public void Start()
    {
        playButton.onClick.AddListener(PlayGame);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
}
