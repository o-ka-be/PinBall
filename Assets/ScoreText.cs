using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public int Score = 0;
    public int ScoreSmallStar = 5;
    public int ScoreLargeStar = 20;
    public int ScoreSmallCloud = 50;
    public int ScoreLargeCloud = 10;

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;
        //SmallStarにぶつかった際の得点加算
        if (tag == "SmallStarTag")
        {
            Score += ScoreSmallStar;
        }
        else if (tag == "LargeStarTag")
        {
            Score += ScoreLargeStar;
        }
        else if (tag == "SmallCloudTag")
        {
            Score += ScoreSmallCloud;
        }
        else if (tag == "LargeCloudTag")
        {
            Score += ScoreLargeCloud;
        }


    }
    //スコアを表示するテキスト
    private GameObject scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //scene中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        //Scoretextに現在のスコアを表示する
        this.scoreText.GetComponent<Text> ().text = "Score" + Score;
        
    }
}
