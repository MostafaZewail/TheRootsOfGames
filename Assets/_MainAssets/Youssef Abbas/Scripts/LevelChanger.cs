using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator anim;
    private int levelToLoad;

    public void FadeToLevel(int levelIndex)
    {
        levelToLoad = 2;
        anim.SetTrigger("FadeOut");

    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    //public void FadeInFunction()
    //{
    //    anim.Play("Fade_In_level");
    //}
}
