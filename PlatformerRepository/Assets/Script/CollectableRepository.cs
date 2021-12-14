using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectableRepository : MonoBehaviour, Observer
{
    private List<Object> _collectables = new List<Object>();
    private int score;
    private float endTime = 10;
    public Text scoreText;
    public Text winText;
    // Start is called before the first frame update
    void Start()
    {
        foreach (SubjectBeingObserved subject in FindObjectsOfType<SubjectBeingObserved>())
        {
            subject.AddObserver(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
        scoreText.text = "Score: " + score.ToString();
    }
    public void OnNotify(Object obj, NotificationType noTy, int pointValue)
    {
        _collectables.Add(obj);
        if (noTy == NotificationType.bronzecoin)
        {
            score = score + pointValue;
        }
        if (noTy == NotificationType.silvercoin)
        {
            score = score + pointValue;
        }
        if (noTy == NotificationType.goldcoin)
        {
            score = score + pointValue;
        }
        if (noTy == NotificationType.finish && score == 40)
        {
            winText.text = "You Win!";
            endTime -= Time.deltaTime;
            if (endTime <= 0)
            {
                SceneManager.LoadScene("Game");
            }
        }
        Destroy(obj);
    }
    public void ReAssess()
    {
        foreach (SubjectBeingObserved subject in FindObjectsOfType<SubjectBeingObserved>())
        {
            subject.AddObserver(this);
        }
    }
}
