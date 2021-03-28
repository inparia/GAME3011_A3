using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int currLockNum = 1;
    public bool gameWin = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            currLockNum++;
            if(currLockNum == 4)
            {
                currLockNum = 1;
            }
        }
    }
}
