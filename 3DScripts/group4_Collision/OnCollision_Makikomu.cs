using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、巻き込む
public class OnCollision_Makikomu : MonoBehaviour
{
	public string tagName; // タグ名：Inspectorで指定

	private void OnCollisionEnter(Collision collision) // 衝突したとき
	{
		// もし、衝突したものが目標のタグを持っていたら
		if (collision.gameObject.tag == tagName)
		{
			// 衝突したものを少し近くに移動して、コライダーを消して、子供にする
			Vector3 pos = (collision.gameObject.transform.position - this.gameObject.transform.position)  / 3;
			collision.gameObject.transform.position -= pos;

			Collider mc = collision.gameObject.GetComponent<Collider>();
			if (mc != null)
			{
				mc.enabled = false;
			}
			collision.gameObject.transform.parent = this.gameObject.transform;
		}
	}
}
