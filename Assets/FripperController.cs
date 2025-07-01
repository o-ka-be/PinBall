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
        //左矢印キーまたはAキー　またはSキーを押したとき左フリッパーを動かす
        if ((Keyboard.current.leftArrowKey.wasPressedThisFrame || Keyboard.current.aKey.wasPressedThisFrame || Keyboard.current.sKey.wasPressedThisFrame) && this.gameObject.CompareTag("LeftFripperTag"))
        {
            SetAngle(this.flickAngle);
        }


            //右矢印キーまたはDキー　またはSキーを押したとき右フリッパーを動かす
            if ((Keyboard.current.rightArrowKey.wasPressedThisFrame || Keyboard.current.dKey.wasPressedThisFrame || Keyboard.current.sKey.wasPressedThisFrame) && this.gameObject.CompareTag("RightFripperTag"))
            {
                SetAngle(this.flickAngle);
            }

        //キーが離された時フリッパーを元に戻す
        if ((Keyboard.current.leftArrowKey.wasReleasedThisFrame || Keyboard.current.aKey.wasReleasedThisFrame || Keyboard.current.sKey.wasReleasedThisFrame) && this.gameObject.CompareTag("LeftFripperTag"))
        {
            SetAngle(this.defaultAngle);
        }
        if ((Keyboard.current.rightArrowKey.wasReleasedThisFrame || Keyboard.current.dKey.wasReleasedThisFrame || Keyboard.current.sKey.wasReleasedThisFrame) && this.gameObject.CompareTag("RightFripperTag"))
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
