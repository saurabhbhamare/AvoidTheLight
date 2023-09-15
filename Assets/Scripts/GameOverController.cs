using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    [SerializeField] Button buttonHome;
    private void Start()
    {
        buttonHome.onClick.AddListener(LoadHomeScene);
    }
   public void LoadHomeScene()
    {
        SceneManager.LoadScene("Lobby");
    }
    public void PlayerDied()
    {
        this.gameObject.SetActive(true);
    }
  
}
