using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void OnClickStartButton()
    {
        FadeManager.Instance.LoadScene("stage_select", 0.3f);
    }
    public void OnClickDescriptionButton()
    {
        FadeManager.Instance.LoadScene("description", 0.3f);
    }
    public void OnClickReturnButton()
    {
        FadeManager.Instance.LoadScene("title", 0.3f);
    }
    public void OnClick1menButton()
    {
        FadeManager.Instance.LoadScene("1men", 0.3f);
    }
    public void OnClick2menButton()
    {
        FadeManager.Instance.LoadScene("2men", 0.3f);
    }
    public void OnClick3menButton()
    {
        FadeManager.Instance.LoadScene("3men", 0.3f);
    }
    public void OnClick4menButton()
    {
        FadeManager.Instance.LoadScene("4men", 0.3f);
    }
    public void OnClick5menButton()
    {
        FadeManager.Instance.LoadScene("5men", 0.3f);
    }
    public void OnClickEndButton()
    {
        Quit();
    }

    void Quit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #elif UNITY_STANDALONE
        UnityEngine.Application.Quit();
        #endif
    }
}
