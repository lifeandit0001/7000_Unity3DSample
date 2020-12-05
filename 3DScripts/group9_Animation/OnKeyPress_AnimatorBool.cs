using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// あるキーを押したら、パラメータの値を変更
public class OnKeyPress_AnimatorBool : MonoBehaviour
{
	public string pushKey = "space";	// キー：Inspectorで指定
	public string parameterName = "";	// パラメータ名：Inspectorで指定
	public bool parameterValue = true;	// パラメータの値：Inspectorで指定

	bool pushFlag = false; // キーを押しっぱなしかどうか

	void Update ()
	{
		if (Input.GetKey(pushKey)) // もし、キーが押されて
		{
			if (pushFlag == false) // 押しっぱなしでなければ
			{
				pushFlag = true; // 押した状態に
				// パラメータの値を変更
				Animator m_Animator = gameObject.GetComponent<Animator>();
				m_Animator.SetBool(parameterName, parameterValue);
			}
		} else
		{
			pushFlag = false; 			// 押した状態解除
		}
	}
}
