using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour {
    public GameObject initialSubPanel;
    public GameObject startSubPanel;
    public GameObject otherSubPanel;
    public GameObject optionSubPanel;
    
    public Image title;

    public void EasyStartGame()
    {
        GameManager.level = 0;
        SceneManager.LoadScene("SampleScene");
        
    }

    public void NormalStartGame()
    {
        GameManager.level = 1;
        SceneManager.LoadScene("SampleScene");

    }

    public void HardStartGame()
    {
        GameManager.level = 2;
        SceneManager.LoadScene("SampleScene");

    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ActiveInitialPanel()
    {
        title.gameObject.SetActive(true);

        initialSubPanel.SetActive(true);
        
        startSubPanel.SetActive(false);
        otherSubPanel.SetActive(false);

        optionSubPanel.SetActive(false);
    }

    public void ActiveStartPanel()
    {
        title.gameObject.SetActive(false);

        initialSubPanel.SetActive(false);
        
        startSubPanel.SetActive(true);
        otherSubPanel.SetActive(true);

        optionSubPanel.SetActive(false);
    }

    public void ActiveOptionPanel()
    {
        startSubPanel.SetActive(false);
        otherSubPanel.SetActive(false);

        optionSubPanel.SetActive(true);

    }

    private void Start()
    {
        ActiveInitialPanel();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
