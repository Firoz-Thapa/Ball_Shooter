using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButtonController : MonoBehaviour
{
    public GameObject startPanel;

    private void Start()
    {

        startPanel.SetActive(true);
    }

    public void StartGame()
    {

 
        SceneManager.LoadScene("GameScene"); 
    }

    public void CloseStartPanel()
    {

        startPanel.SetActive(false);
    }
    public void QuitGame()
    {

        Application.Quit();
    }
}
