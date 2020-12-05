using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、回転する
public class Forever_Rotate : MonoBehaviour
{
	public float angleY = 90; // 角度Y：Inspectorで指定
	public float angleZ = 0;  // 角度Z：Inspectorで指定

	private void FixedUpdate() // ずっと、回転する
	{
		this.transform.Rotate(0, angleY/50, angleZ/50);	// 回転する
	}
}
