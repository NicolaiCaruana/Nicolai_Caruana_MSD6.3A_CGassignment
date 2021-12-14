using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float p1Score;
    public float p2Score;

    //public TMPro.TextMeshProUGUI p1Text;
    //public TMPro.TextMeshProUGUI p2Text;

    public Text p1Text;
    public Text p2Text;

    // Start is called before the first frame update
    void Start()
    {
        p1Score = 0;
        p2Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        p1Text.text = "Player 1: " + p1Score.ToString();
        p2Text.text = "Player 2: " + p2Score.ToString();

        if (p1Score >= 100f || p2Score >= 100f)
        {
            p1Score = 0;
            p2Score = 0;
            SceneManager.LoadScene("EndScene");
        }
    }
}
