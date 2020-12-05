using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// タッチしたら、回転する
public class OnMouseDown_Rotate : MonoBehaviour 
{
	public float angleX = 0;   // 角度X：Inspectorで指定
	public float angleY = 360; // 角度Y：Inspectorで指定
	public float angleZ = 0;   // 角度Z：Inspectorで指定

	float rotateAngleX = 0;
	float rotateAngleY = 0;
	float rotateAngleZ = 0;

	private void OnMouseDown() // タッチしたら、回転量を指定する
	{
		rotateAngleX = angleX; 
		rotateAngleY = angleY;
		rotateAngleZ = angleZ;
	}

	private void OnMouseUp() // タッチをやめたら、回転量を0にする
	{
		rotateAngleX = 0;
		rotateAngleY = 0;
		rotateAngleZ = 0;
	}

	private void FixedUpdate() // ずっと、指定量で回転する
	{
		this.transform.Rotate(rotateAngleX/50, rotateAngleY/50, rotateAngleZ/50);
	}
}
