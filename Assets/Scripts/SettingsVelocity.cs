using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class SettingsVelocity : MonoBehaviour

{
    [SerializeField] private Movementplayer1 player1;
    [SerializeField] private Movementplayer2 player2;

    [SerializeField] private Slider Sliderplayer1;
    [SerializeField] private Slider Sliderplayer2;

    [SerializeField] private TMP_Text Speedplayer1text;
    [SerializeField] private TMP_Text Speedplayer2text;

         // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sliderplayer1.value = player1.speed;
        Sliderplayer2.value = player2.speed;

        Speedplayer1text.text = "Speed: " + player1.speed;
        Speedplayer2text.text = "Speed: " + player2.speed;

        Sliderplayer1.onValueChanged.AddListener(ChangeSpeedPlayer1);
        Sliderplayer2.onValueChanged.AddListener(ChangeSpeedPlayer2);
    }

    private void ChangeSpeedPlayer1(float newSpeed)
    {
        player1.speed = newSpeed;
        Speedplayer1text.text = "Speed: " + newSpeed;
    }

    private void ChangeSpeedPlayer2(float newSpeed)
    {
        player2.speed = newSpeed;
        Speedplayer2text.text = "Speed: " + newSpeed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
