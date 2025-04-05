using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void LoadGame()
    {
        Debug.Log("Loading Game...");
        SceneManager.LoadScene("Level 1");
    }
}