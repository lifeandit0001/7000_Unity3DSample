using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押したら、移動する
public class OnKeyPress_Move : MonoBehaviour
{
	public float speed = 2; // スピード：Inspectorで指定

	float vx = 0;
	float vz = 0;
 
	void Update() // 左右キーでX方向、上下キーでZ方向の移動量を設定する
	{
		vx = Input.GetAxisRaw("Horizontal") * speed;
		vz = Input.GetAxisRaw("Vertical") * speed;
	}
	private void FixedUpdate() // ずっと、移動する
	{
		this.transform.Translate(vx / 50, 0,  vz / 50);
	}
}
