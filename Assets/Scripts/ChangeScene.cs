using UnityEngine;
using UnityEngine.SceneManagement;



public class ChangeScene : MonoBehaviour
{

    public void PlayScene()
    {
        SceneManager.LoadScene("Level1");
    }

    public void HowToScene()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
        GlobalControl.Instance.totalEnemyKills = 0;

    }
    public void TutorialScene()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void ScoreScene()
    {
        SceneManager.LoadScene("ScoreScreen");
    }

    public void SynopsisScreen()
    {
        SceneManager.LoadScene("Synopsis");
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }
    public void QuitGame()
    {
        //Only works when built and run as an application
        Application.Quit();
    }
}