using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIandScoreManager : MonoBehaviour
{
    public Text ScoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score " + score;
    }

    public void ScoreIncrease()
    {
        score += 1;
    }
    public void ScoreIncreaseBird()
    {
        score += 3;
    }
    public void ScoreIncreaseBigBird()
    {
        score += 5;
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
