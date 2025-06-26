using UnityEngine;

public class StarController : MonoBehaviour
{

    // 回転速度
    private float rotSpeed = 0.3f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);    
    }

    // Update is called once per frame
    void Update()
    {
        // 回転
       this.transform.Rotate(0, this.rotSpeed, 0);

         
    }
}
