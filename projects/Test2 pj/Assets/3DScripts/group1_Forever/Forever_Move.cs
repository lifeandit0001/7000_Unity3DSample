using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、移動する
public class Forever_Move : MonoBehaviour
{
	public float speedX = 1; // スピードX：Inspectorで指定
	public float speedY = 0; // スピードY：Inspectorで指定
	public float speedZ = 0; // スピードZ：Inspectorで指定

	private void FixedUpdate() // ずっと、移動する
	{
		this.transform.Translate(speedX / 50, speedY / 50, speedZ / 50); 
	}
}
