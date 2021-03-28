using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BarrelTimer : MonoBehaviour
{
    public TMPro.TMP_Text text;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameManager.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Barrel Explodes in " + (int)gameManager.gameTimer + " seconds.";

        if (gameManager.gameWin)
            Destroy(gameObject);
    }
}
