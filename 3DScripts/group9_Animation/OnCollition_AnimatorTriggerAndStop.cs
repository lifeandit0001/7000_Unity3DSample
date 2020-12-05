using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、トリガー発生、しばらくして停止
public class OnCollition_AnimatorTriggerAndStop : MonoBehaviour
{
	public string tagName; // 目標オブジェクト名：Inspectorで指定
	public string triggerName = "";	// trigger名：Inspectorで指定
	public int stopSec = 1;	// 停止までの秒数：Inspectorで指定

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			// アニメーターのトリガー発生
			Animator m_Animator = gameObject.GetComponent<Animator>();
			m_Animator.SetTrigger(triggerName);
			// しばらくして停止
			Invoke("gameStop", stopSec);
		}
	}
	void gameStop()	// 時間を止める命令
	{
		Time.timeScale = 0;
	}
}
