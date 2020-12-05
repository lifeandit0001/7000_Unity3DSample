using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ずっと、移動する（相手には物理的作用を与えるように）
public class Forever_Move_Kinematic : MonoBehaviour
{
	public float speedX = 1; // スピードX：Inspectorで指定
	public float speedY = 0; // スピードY：Inspectorで指定
	public float speedZ = 0; // スピードZ：Inspectorで指定

	Rigidbody rbody;

	void Start() // 最初に、相手には物理的作用を与えるようにする
	{
		rbody = this.GetComponent<Rigidbody>();
		rbody.isKinematic = true;
	}

	private void FixedUpdate() // ずっと、移動する
	{
		Vector3 moveVelocity = new Vector3(speedX/50, speedY/50, speedZ/50);
		rbody.MovePosition(transform.position + moveVelocity);
	}
}
