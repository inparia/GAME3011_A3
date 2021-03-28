using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockScript : MonoBehaviour
{
    public int LockNum;
    public int currNumChoose = 0;
    public bool rightNum = false;
    public GameObject arrow, lockMove;
    // Start is called before the first frame update
    void Start()
    {
        lockMove = GameObject.FindGameObjectWithTag("LockMove");
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponentInParent<LockCheck>().currLockNum == LockNum)
        {
            arrow.SetActive(true);
        }
        else
        {
            arrow.SetActive(false);
        }

        if (GetComponentInParent<LockCheck>().isInputEnabled)
        {
            
            if (Input.GetKeyDown("down") && GetComponentInParent<LockCheck>().currLockNum == LockNum)
            {
                lockMove.GetComponent<AudioSource>().Play();
                gameObject.transform.Rotate(36.0f, 0.0f, 0.0f, Space.World);
                currNumChoose++;
                if (currNumChoose > 9)
                {
                    currNumChoose = 0;
                }
            }
            if (Input.GetKeyDown("up") && GetComponentInParent<LockCheck>().currLockNum == LockNum)
            {
                lockMove.GetComponent<AudioSource>().Play();
                gameObject.transform.Rotate(-36.0f, 0.0f, 0.0f, Space.World);
                currNumChoose--;
                if (currNumChoose < 0)
                {
                    currNumChoose = 9;
                }
            }
        }
        switch(LockNum)
        {
            case 1:
                if(currNumChoose == GetComponentInParent<LockCheck>().keyCodes[0])
                {
                    if(!rightNum)
                    {
                        GetComponentInParent<LockCheck>().winCondition++;
                    }
                    rightNum = true;
                }
                else
                {
                    if(rightNum)
                    {
                        GetComponentInParent<LockCheck>().winCondition--;
                    }
                    rightNum = false;
                }
                break;
            case 2:
                if (currNumChoose == GetComponentInParent<LockCheck>().keyCodes[1])
                {
                    if (!rightNum)
                    {
                        GetComponentInParent<LockCheck>().winCondition++;
                    }
                    rightNum = true;
                }
                else
                {
                    if (rightNum)
                    {
                        GetComponentInParent<LockCheck>().winCondition--;
                    }
                    rightNum = false;
                }
                break;
            case 3:
                if (currNumChoose == GetComponentInParent<LockCheck>().keyCodes[2])
                {
                    if (!rightNum)
                    {
                        GetComponentInParent<LockCheck>().winCondition++;
                    }
                    rightNum = true;
                }
                else
                {
                    if (rightNum)
                    {
                        GetComponentInParent<LockCheck>().winCondition--;
                    }
                    rightNum = false;
                }
                break;
        }
    }
}
