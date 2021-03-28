using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LockCheck : MonoBehaviour
{
    public GameManager gameManager;
    public bool isInputEnabled;
    public int currLockNum;
    public float remainingTime;
    public int[] keyCodes;
    public int winCondition = 0;
    public GameObject pole, lockMatch;
    float x = 0;
    // Start is called before the first frame update
    void Start()
    {
        lockMatch = GameObject.FindGameObjectWithTag("LockMatch");
        gameManager = GameManager.FindObjectOfType<GameManager>();
        switch (gameManager.difficulty)
        {
            case Difficulty.EASY:
                keyCodes = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    remainingTime = 180;
                    keyCodes[i] = Random.Range(0, 10);
                }
                break;
            case Difficulty.NORMAL:
                keyCodes = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    remainingTime = 120;
                    keyCodes[i] = Random.Range(0, 10);
                }
                break;
            case Difficulty.HARD:
                keyCodes = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    remainingTime = 60;
                    keyCodes[i] = Random.Range(0, 10);
                }
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.gameWin)
        {
            remainingTime -= Time.deltaTime;
            gameManager.gameTimer = remainingTime;
        }

        isInputEnabled = gameManager.isInputEnabled;
        currLockNum = gameManager.currLockNum;

        if(remainingTime <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
        switch (gameManager.difficulty)
        {
            case Difficulty.EASY:
                if (winCondition == 3)
                {
                    if(!gameManager.gameWin)
                        lockMatch.GetComponent<AudioSource>().Play();
                    gameManager.gameWin = true;
                }
                else
                {
                    gameManager.gameWin = false;
                }
                break;
            case Difficulty.NORMAL:
                if (winCondition == 4)
                {
                    if (!gameManager.gameWin)
                        lockMatch.GetComponent<AudioSource>().Play();
                    gameManager.gameWin = true;
                }
                else
                {
                    gameManager.gameWin = false;
                }
                break;
            case Difficulty.HARD:
                if (winCondition == 5)
                {
                    if (!gameManager.gameWin)
                        lockMatch.GetComponent<AudioSource>().Play();
                    gameManager.gameWin = true;
                }
                else
                {
                    gameManager.gameWin = false;
                }
                break;
        }

        if(gameManager.gameWin)
        {
            gameManager.isInputEnabled = false;
            pole = GameObject.FindGameObjectWithTag("Pole");
            if (x <= 6)
            {
                x += Time.deltaTime;
                pole.transform.position = new Vector3(x, 0, 0);
            }

            else
            {
                Destroy(pole);
                Destroy(gameObject);
                gameManager.resetGame();
                
            }
        }
      

    }
}
