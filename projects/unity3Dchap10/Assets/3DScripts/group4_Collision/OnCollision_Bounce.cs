using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、衝突したものを跳ね返す
public class OnCollision_Bounce : MonoBehaviour
{
	public string tagName; // タグ名：Inspectorで指定
	public float speed = 1f;

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			// 離れた位置に移動する
			Vector3 pos = collision.gameObject.transform.position;
			Vector3 myPos = this.gameObject.transform.position;
			Vector3 dist = (myPos - pos) * speed;
			pos.x = pos.x - dist.x;
			pos.z = pos.z - dist.z;
			collision.gameObject.transform.position = pos;
		}
	}
}
