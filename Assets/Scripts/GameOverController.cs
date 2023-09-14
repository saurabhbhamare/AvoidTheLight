using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    void Start()
    {
    }
    public void PlayerDied()
    {
        this.gameObject.SetActive(true);
    }
  
}
