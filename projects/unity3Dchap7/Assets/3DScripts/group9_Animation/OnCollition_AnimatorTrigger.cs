using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、トリガー発生
public class OnCollition_AnimatorTrigger : MonoBehaviour
{
	public string tagName; // タグ名：Inspectorで指定
	public string triggerName = "";	// trigger名：Inspectorで指定

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			// アニメーターのトリガー発生
			Animator m_Animator = gameObject.GetComponent<Animator>();
			m_Animator.SetTrigger(triggerName);
		}
	}
}
