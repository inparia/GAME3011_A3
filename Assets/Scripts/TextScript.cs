using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TMPro.TMP_Text>().text = "Timer : " + (int)gameManager.gameTimer + " seconds.";
    }
}
