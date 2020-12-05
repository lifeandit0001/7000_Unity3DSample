using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、回転する（相手には物理的作用を与えるように）
public class Forever_Rotate_Kinematic : MonoBehaviour
{
	public float angleX = 0;  // 角度X：Inspectorで指定
	public float angleY = 30; // 角度Y：Inspectorで指定
	public float angleZ = 0;  // 角度Z：Inspectorで指定

	Rigidbody rbody;

	void Start() // 最初に、相手には物理的作用を与えるようにする
	{
		rbody = this.GetComponent<Rigidbody>();
		rbody.isKinematic = true;
	}

	private void FixedUpdate() // ずっと、回転する
	{
		Quaternion deltaRotation = Quaternion.Euler(new Vector3(angleX / 50, angleY/50, angleZ/50));
		rbody.MoveRotation(transform.rotation * deltaRotation);
	}
}
