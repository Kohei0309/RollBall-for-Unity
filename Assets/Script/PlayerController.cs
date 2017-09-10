using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Speedを制御
	public float speed = 10;

	void Start () {
		// ジャイロセンサーを有効化
		Input.gyro.enabled = true;
	}

//	// 物理演算でキャラクターが動くたびに更新
//	void FixedUpdate() {
//		// 入力をxとyに代入
//		float x = Input.GetAxis ("Horizontal");
//		float z = Input.GetAxis ("Vertical");
//		// 同一のGameObjectが持つRigidbodyコンポーネントを取得
//		Rigidbody rigidbody = GetComponent<Rigidbody>();
//		rigidbody.AddForce(x * speed, 0, z * speed);
//	}

	void FixedUpdate()
	{
		Vector3 gravityV = Input.gyro.gravity;
		// 外力のベクトルを計算.
		float scale = 10.0f;
		Vector3 forceV = new Vector3(gravityV.x, 0.0f, gravityV.y) * scale;
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.AddForce(forceV);
	}
}
