using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 時間が経ったら、自分自身を削除する
public class OnTimeout_DestroyMe : MonoBehaviour
{
	public float limitSec = 3; // 秒数：Inspectorで指定

	void Start() // 最初に、指定した秒数で削除する予約をする
	{
		Destroy(this.gameObject, limitSec);
	}
}
