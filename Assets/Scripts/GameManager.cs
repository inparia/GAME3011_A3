using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Difficulty
{
    EASY,
    NORMAL,
    HARD
}

public class GameManager : MonoBehaviour
{
    public int currLockNum = 1;
    public bool gameWin = false;
    public bool isInputEnabled = true;
    public Difficulty difficulty;
    public GameObject lockOne, lockTwo, lockThree, pole, canvas, barrel, panel;
    public float gameTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void resetGame()
    {
        canvas.SetActive(true);
        currLockNum = 1;
        difficulty = Difficulty.EASY;
        gameWin = false;
        isInputEnabled = true;
        panel.SetActive(false);
    }
    public void GenerateLocks()
    {
        switch (difficulty)
        {
            case Difficulty.EASY:
                var tempLockOne = Instantiate(lockOne, new Vector3(0, 0, 0), Quaternion.identity);
                //lockOne.SetActive(true);
                break;
            case Difficulty.NORMAL:
                var tempLockTwo = Instantiate(lockTwo, new Vector3(0, 0, 0), Quaternion.identity);
                break;
            case Difficulty.HARD:
                var tempLockThree = Instantiate(lockThree, new Vector3(0, 0, 0), Quaternion.identity);
                var tempBarrel = Instantiate(barrel, new Vector3(-7, -3, 0), Quaternion.identity);
                break;
        }

        var tempPole = Instantiate(pole, new Vector3(0, 0, 0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        if (isInputEnabled)
        {
            if (Input.GetKeyDown("right"))
            {
                switch (difficulty)
                {
                    case Difficulty.EASY:
                        currLockNum++;
                        if (currLockNum == 4)
                        {
                            currLockNum = 1;
                        }
                        break;
                    case Difficulty.NORMAL:
                        currLockNum++;
                        if (currLockNum == 5)
                        {
                            currLockNum = 1;
                        }
                        break;
                    case Difficulty.HARD:
                        currLockNum++;
                        if (currLockNum == 6)
                        {
                            currLockNum = 1;
                        }
                        break;
                }

            }

            if (Input.GetKeyDown("left"))
            {
                switch (difficulty)
                {
                    case Difficulty.EASY:
                        currLockNum--;
                        if (currLockNum == 0)
                        {
                            currLockNum = 3;
                        }
                        break;
                    case Difficulty.NORMAL:
                        currLockNum--;
                        if (currLockNum == 0)
                        {
                            currLockNum = 4;
                        }
                        break;
                    case Difficulty.HARD:
                        currLockNum--;
                        if (currLockNum == 0)
                        {
                            currLockNum = 5;
                        }
                        break;
                }

            }
        }
    }
}
