using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    private Text _scoreText;
    private GameSession _gameSession;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _scoreText = GetComponent<Text>();
        _gameSession = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        string score = _gameSession.GetScore().ToString();
        string temp = _scoreText.text.Substring(0, _scoreText.text.Length - score.Length) + score;
        _scoreText.text = temp;
    }
}
