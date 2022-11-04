using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreLabel;

    private int _score;

    void Awake()
    {
        EventManager.StartListening(GameEvent.COIN_CATCH, CoinCatch);
    }

    void OnDestroy()
    {
        EventManager.StopListening(GameEvent.COIN_CATCH, CoinCatch);
    }

    void Start()
    {
        _score = 0;
        scoreLabel.text = "Score: " + _score.ToString();
    }

    private void CoinCatch()
    {
        _score += 1;
        scoreLabel.text = "Score: " + _score.ToString();
    }
}
