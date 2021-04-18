using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float deathfadeDuration = 1f;
    public float displayImageDuration = 1f;
   
    public CanvasGroup winBackgroundImageCanvasGroup;
    public CanvasGroup deathBackgroundImageCanvasGroup;

    bool m_Win;
    bool m_Death;
    float m_Timer;
    float a;

    public void Death()
    {
  
        m_Death = true;
        
    }

    public void Win()
    {
        m_Win = true;
    }

    void Update()
    {
        if (m_Win)
        {
            EndLevel(winBackgroundImageCanvasGroup, false);
        }
        else if (m_Death)
        {
            EndLevel(deathBackgroundImageCanvasGroup, true);
        }
    }

    public void EndLevel(CanvasGroup imageCanvasGroup, bool doRestart)
    {
        m_Timer += Time.deltaTime;
    

        if (imageCanvasGroup == winBackgroundImageCanvasGroup)
        {
            imageCanvasGroup.alpha = m_Timer / fadeDuration;
        }

        if (imageCanvasGroup == deathBackgroundImageCanvasGroup)
        {
            imageCanvasGroup.alpha = m_Timer / fadeDuration;

        }

        

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            if (doRestart)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                Application.Quit();
            }
        }
    }
}
