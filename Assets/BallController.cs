using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    // ボールが見える可能性があるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバーを表示する""
    private GameObject gameoverText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
}
