using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonBehaviours : MonoBehaviour
{
    public GameManager gameManager;
    public Button buttonOne, buttonTwo, buttonThree;
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        switch(gameManager.difficulty)
        {
            case Difficulty.EASY:
                buttonOne.interactable = false;
                buttonTwo.interactable = true;
                buttonThree.interactable = true;
                break;
            case Difficulty.NORMAL:
                buttonTwo.interactable = false;
                buttonOne.interactable = true;
                buttonThree.interactable = true;
                break;
            case Difficulty.HARD:
                buttonThree.interactable = false;
                buttonTwo.interactable = true;
                buttonOne.interactable = true;
                break;
        }

    }

    public void easyButtonCheck()
    {
        gameManager.difficulty = Difficulty.EASY;
    }

    public void normalButtonCheck()
    {
        gameManager.difficulty = Difficulty.NORMAL;
    }

    public void hardButtonCheck()
    {
        gameManager.difficulty = Difficulty.HARD;
    }

    public void GenerateLock()
    {
        gameManager.GenerateLocks();
        gameObject.SetActive(false);
        panel.SetActive(true);
    }
}
