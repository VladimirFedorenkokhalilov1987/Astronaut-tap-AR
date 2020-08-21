using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameStartController: MonoBehaviour
{
    public  GameObject FigureSpawner;
    public Text CountDown;
    public GameObject ScoreText;
    private bool _gameIsStarted;

    IEnumerator CountAndStart()
    {
        for (int i = 3; i > 0; i--)
        {
            CountDown.text = i.ToString();
            yield return GameConst.waitTime;
        }

        CountDown.text =GameConst.StartText;
        FigureSpawner.SetActive(true);
        yield return GameConst.waitTime;
        CountDown.gameObject.SetActive(false);
        ScoreText.SetActive(true);
        _gameIsStarted = true;
    }

    public  void StartGame()
    {
        if (!_gameIsStarted)
        {
            StartCoroutine(CountAndStart());
        }
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        if (Time.timeScale == 1)
            Time.timeScale = 0;
    }
}
