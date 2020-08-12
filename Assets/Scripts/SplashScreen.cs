using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScreen : MonoBehaviour
{

    public Image splashImage;
    public string menuScene;
    public float timeToFadeIn;
    public float timeToFadeOut;
    public float timeUntilFadeOut;
    public float timeUntilNextScene;


    private IEnumerator Start()
    {
        splashImage.canvasRenderer.SetAlpha(0.0f);
        FadeIn();
        yield return new WaitForSeconds(timeUntilFadeOut);
        FadeOut();
        yield return new WaitForSeconds(timeUntilNextScene);
        SceneManager.LoadScene("Menu");

    }

    public void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, timeToFadeIn, false);
    }

    public void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, timeToFadeIn, false);
    }


}
