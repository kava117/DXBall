using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Button startButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SceneManager.LoadScene("Menu");
        startButton.onClick.AddListener(StartGame);
    }


    void StartGame()
    {
        Debug.Log("BUTTON CLICKED");
    }
}
