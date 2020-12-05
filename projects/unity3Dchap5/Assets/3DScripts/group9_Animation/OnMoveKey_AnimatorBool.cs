using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 上下左右キーを押したら、パラメータの値を変更
public class OnMoveKey_AnimatorBool : MonoBehaviour
{
	public string parameterName = "";	// パラメータ名：Inspectorで指定

	void Update ()
	{
		// もし、上下左右キーを押したら
		bool pushFlag = false;
		if (Input.GetKey("up"))
		{
			pushFlag = true;
		}
		if (Input.GetKey("down"))
		{
			pushFlag = true;
		}
		if (Input.GetKey("right"))
		{
			pushFlag = true;
		}
		if (Input.GetKey("left"))
		{
			pushFlag = true;
		}
		// パラメータの値を変更
		Animator m_Animator = gameObject.GetComponent<Animator>();
		m_Animator.SetBool(parameterName, pushFlag);
	}
}
