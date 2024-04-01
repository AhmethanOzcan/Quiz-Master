using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EndScreen : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI finalScoreText;
    [SerializeField] ScoreKeeper scoreKeeper;


    public void ShowFinalScore()
    {
        finalScoreText.text = "Congratulayions!\nYou scored " + scoreKeeper.CalculateScore() + "%";
    }

}
