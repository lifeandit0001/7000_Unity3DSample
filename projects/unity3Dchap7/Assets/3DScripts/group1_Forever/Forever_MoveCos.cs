using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、往復する
public class Forever_MoveCos : MonoBehaviour
{
	public float speedX = 0; // スピードX：Inspectorで指定
	public float speedY = 0; // スピードY：Inspectorで指定
	public float speedZ = 1; // スピードZ：Inspectorで指定
	public float second = 1; // かかる秒数：Inspectorで指定
	
	float time = 0f;

	private void FixedUpdate() // ずっと、往復する
	{
		time += Time.deltaTime;
		float s = Mathf.Cos(time * 3.14f / second);  // 移動量を求める
		this.transform.Translate(speedX * s / 50, speedY * s / 50, speedZ * s / 50); 
	}
}
