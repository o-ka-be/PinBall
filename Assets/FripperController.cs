using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class FripperController : MonoBehaviour
{
            //　HingeJointコンポーネントを入れる
        private HingeJoint myHingeJoint;

    // 初期の傾き
    private float defaultAngle = 20;

    //弾いた時の傾き
    private float flickAngle = -20;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // HingeJointコンポーネント取得
        this.myHingeJoint = GetComponent<HingeJoint>();

        // フリッパーの傾きを設定
        SetAngle(this.defaultAngle);

    }
    
    // Update is called once per frame
    void Update()
    {
        //左矢印キーを押したとき左フリッパーを動かす
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame && this.gameObject.CompareTag("LeftFripperTag"))
        {
            SetAngle(this.flickAngle);
        }
        //キーボードの右矢印キーを押したとき右フリッパーを動かす
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame && this.gameObject.CompareTag("RightFripperTag"))
        {
            SetAngle(this.flickAngle);
        }

        //矢印キーが離された時フリッパーを元に戻す
        if (Keyboard.current.leftArrowKey.wasReleasedThisFrame && this.gameObject.CompareTag("LeftFripperTag"))
        {
            SetAngle(this.defaultAngle);
        }
        if (Keyboard.current.rightArrowKey.wasReleasedThisFrame && this.gameObject.CompareTag("RightFripperTag"))
        {
            SetAngle(this.defaultAngle);
        }
}
    //フリッパーの傾きを設定
    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}
