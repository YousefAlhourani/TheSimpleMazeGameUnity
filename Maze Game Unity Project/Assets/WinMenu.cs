﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void PlayGame()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
  }

  public void QuitGame()
  {
      Application.Quit();
  }
}
