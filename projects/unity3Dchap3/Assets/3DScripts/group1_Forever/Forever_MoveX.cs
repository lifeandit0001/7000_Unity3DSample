using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、移動する
public class Forever_MoveX : MonoBehaviour
{
	public float speedX = 1; // スピードX：Inspectorで指定

	private void FixedUpdate() // ずっと、移動する
	{
		this.transform.Translate(speedX / 50, 0, 0);
	}
}
