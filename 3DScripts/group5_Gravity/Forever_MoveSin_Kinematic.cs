using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// ずっと、往復する（相手には物理的作用を与えるように）
public class Forever_MoveSin_Kinematic : MonoBehaviour
{
	public float speedX = 1; // スピードX：Inspectorで指定
	public float speedY = 0; // スピードY：Inspectorで指定
	public float speedZ = 0; // スピードZ：Inspectorで指定
	public float second = 1f;

	float time = 0f;
	Rigidbody rbody;

	void Start() // 最初に、相手には物理的作用を与えるようにする
	{
		rbody = this.GetComponent<Rigidbody>();
		rbody.isKinematic = true;
	}

	private void FixedUpdate() // ずっと、往復する
	{
		time += Time.deltaTime;
		float s = Mathf.Sin(time*3.14f/second);
		Vector3 moveVelocity = new Vector3(speedX*s/50, speedY*s/50, speedZ*s/50);
		rbody.MovePosition(this.transform.position + moveVelocity);
	}
}
