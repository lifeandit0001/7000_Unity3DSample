using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチしたら、トリガー発生
public class OnMouseDown_AnimatorTrigger : MonoBehaviour
{
	public string triggerName = "";	// trigger名：Inspectorで指定

	private void OnMouseDown() // タッチしたら、アニメーターのトリガー発生
	{
		Animator m_Animator = gameObject.GetComponent<Animator>();
		m_Animator.SetTrigger(triggerName);
	}
}
