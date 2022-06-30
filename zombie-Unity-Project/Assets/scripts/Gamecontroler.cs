using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gamecontroler : MonoBehaviour
{
    public static int Score = 0;

    public string ScoreString = "Score";

    public Text TextScore;
    public static Gamecontroler Gamecontroller;


    public void Awake()
    {
       Gamecontroller = this;
    }

   void Start()
    {
        Score = 0;
    }
    
    void Update()
    {
        if(TextScore != null)
        {
            TextScore.text = ScoreString + Score.ToString();
        }
    }
}
