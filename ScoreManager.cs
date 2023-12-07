using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour
{
    public Text scoreText;      //引用UI文本组件
    public static int score = 0;


    public void Update()
    {
        scoreText.text = score.ToString();      //实时更新分数
    }



    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        score = 0;      //重置分数
    }
}
