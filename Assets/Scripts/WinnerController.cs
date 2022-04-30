using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinnerController : MonoBehaviour
{
    [SerializeField] private Timer timer;
    [SerializeField] private WinnerPanel winnerPanel;
    [SerializeField] private Button restartButton;

    [SerializeField] private GameObject winnerPopUp;
    [SerializeField] private TMP_Text winnerNameText;
    [SerializeField] private TMP_Text winnerTimeText;

    void Start()
    {
        restartButton.onClick.AddListener(RestartScene);
    }

    private void RestartScene()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        
    }

    void Update()
    {
        if (!String.IsNullOrEmpty(winnerPanel.Name))
        {
            winnerPopUp.SetActive(true);
            SetDataOfWinner();
        }    
    }

    private void SetDataOfWinner()
    {
        winnerTimeText.text = string.Format("{0:00}.{1:000}", timer.Seconds, timer.Milliseconds);
        winnerNameText.text = winnerPanel.Name;
    }   
}
