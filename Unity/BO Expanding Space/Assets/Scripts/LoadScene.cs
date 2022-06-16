using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public GameObject player;
    public GameObject overlay;
    public GameObject overlay2;

    int current;
    public void quit(string sceneName)
    {
        Application.Quit();
    }
    public void startgame(string sceneName)
    {
        SceneManager.LoadScene(1);
    }
    public void Menu(string sceneName)
    {
        SceneManager.LoadScene(0);
    }
    public void Back(string sceneName)
    {
        player.GetComponent<PlayerMovement>().enabled = true;
        player.GetComponent<Player>().enabled = true;
        overlay.SetActive(false);
        overlay2.SetActive(true);

    }
}
