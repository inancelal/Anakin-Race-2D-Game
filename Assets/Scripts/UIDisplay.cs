using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIDisplay : MonoBehaviour
{   
    [SerializeField] Slider healthSlider;
    [SerializeField] Health playerHealth;
    [SerializeField] TMP_Text scoreText;
    ScoreKeeper scoreKeeper;

    void Start()
    {
        healthSlider.maxValue = playerHealth.GetHealth();
    }

    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Update()
    {
        scoreText.text = scoreKeeper.GetScore().ToString("00000000000");
        healthSlider.value = playerHealth.GetHealth();
    }
}
