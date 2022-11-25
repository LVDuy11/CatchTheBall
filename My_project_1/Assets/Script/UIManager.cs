using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text score;
    public GameObject gameOverPanel;
    
    public void SetScoreTxt(string txt)
    {   
        if (score)
            score.text = txt;
    }

    public void ShowGameOverPanel(bool isShow)
    {
        if (gameOverPanel)
            gameOverPanel.SetActive(isShow);
    }
}
