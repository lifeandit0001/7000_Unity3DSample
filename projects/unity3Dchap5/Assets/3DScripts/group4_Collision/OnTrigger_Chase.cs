using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 近寄ったら、ずっと追いかける
public class OnTrigger_Chase : MonoBehaviour
{
	public string tagName; // 目標タグ名：Inspectorで指定
	public float speed = 1; // スピード：Inspectorで指定

	GameObject targetObject;
	Rigidbody rbody;

	void Start () // 最初に、目標オブジェクトを見つけておく
	{
		targetObject = GameObject.FindGameObjectWithTag(tagName);
	}
	private void OnTriggerStay(Collider collider) // 目標オブジェクトが触れたとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collider.gameObject.tag == tagName)
		{
			// 目標オブジェクトの方向を調べて
			Vector3 dir = (targetObject.transform.position - this.transform.position).normalized;
			// その方向へ指定した量で進む
			float vx = dir.x * speed;
			float vz = dir.z * speed;
			this.transform.Translate(vx/50, 0,  vz/50);
		}
	}
}
