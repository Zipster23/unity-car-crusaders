using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject creditsPanel;
    public AudioSource menuMusic; // ← Add this

    public void PlayGame()
    {
        if (menuMusic != null)
        {
            menuMusic.Stop(); // Stop the menu music
        }

        SceneManager.LoadScene("City Map"); // Load your actual game scene
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowCredits()
    {
        creditsPanel.SetActive(true);
    }

    public void HideCredits()
    {
        creditsPanel.SetActive(false);
    }
}