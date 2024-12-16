using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btnStartGame : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private string sceneToLoad = "MainGame";

    public void startGame()
    {
        Debug.Log("Start Game Button Clicked!");
        SceneManager.LoadScene(sceneToLoad);
    }
}