using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// キーを押したら、移動＆回転＆ジャンプする
public class OnKeyPress_MoveRotateGravity : MonoBehaviour
{
	public float speed = 3;        // スピード：Inspectorで指定
	public float rotateSpeed = 90; // 回転スピード：Inspectorで指定
	public float jumppower = 6;    // ジャンプ力：Inspectorで指定

	float vz = 0;
	float angle = 0;
	bool pushFlag = false;   // スペースキーを押しっぱなしかどうか
	bool jumpFlag = false;   // ジャンプ状態かどうか
	bool groundFlag = false; // 足が何かに触れているかどうか
	Rigidbody rbody;

	void Start () // 最初に、衝突しても回転させなくしておく（横回転は可）
	{
		rbody = this.GetComponent<Rigidbody>();
		rbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
	}

	void Update () // ずっと行う
	{
		angle = Input.GetAxisRaw("Horizontal") * rotateSpeed;
		vz = Input.GetAxisRaw("Vertical") * speed;		

		// もし、スペースキーが押されたとき、足が何かに触れていたら
		if (Input.GetKey("space") && groundFlag)
		{
			if (pushFlag == false) // 押しっぱなしでなければ
			{
				pushFlag = true; // 押した状態に
				jumpFlag = true; // ジャンプの準備
			}
		} else
		{
			pushFlag = false; 	// 押した状態解除
		}
	}
	private void FixedUpdate() { // ずっと
		if (vz !=0) // 移動する
		{
			this.transform.Translate(0, 0,  vz / 50);
		}
		if (angle != 0) // 回転する
		{
			this.transform.Rotate(0, angle / 50, 0);
		}
		// もし、ジャンプするときならジャンプする
		if (jumpFlag)
		{
			jumpFlag = false;
			rbody.AddForce(new Vector3(0, jumppower, 0), ForceMode.Impulse);
		}
	}
	private void OnTriggerStay(Collider collision) // 足が何かに触れたら
	{
		groundFlag = true;
	}
	private void OnTriggerExit(Collider collision) // 足に何も触れなかったら
	{
		groundFlag = false;	//
	}
}
