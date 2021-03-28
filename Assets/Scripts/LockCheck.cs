using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCheck : MonoBehaviour
{
    public GameManager gameManager;
    public int currLockNum;
    public int[] keyCodes;
    public int winCondition = 0;
    // Start is called before the first frame update
    void Start()
    {
        keyCodes = new int[3];
        for (int i = 0; i < 3; i++)
        {
            keyCodes[i] = Random.Range(0, 10);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currLockNum = gameManager.currLockNum;
        
        if(winCondition == 3)
        {
            gameManager.gameWin = true;
        }
        else
        {
            gameManager.gameWin = false;
        }

    }
}
