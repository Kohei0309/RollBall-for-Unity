using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	// ターゲットへの参照
	public Transform target;
	// ターゲットとカメラの相対距離
	private Vector3 offset;

	void Start() {
		// ターゲットとカメラの相対距離を取得する
		offset = GetComponent<Transform>().position - target.position;
	}

	void Update() {
		// カメラの座標に、ターゲットの座標に相対距離を足した値を設定する
		GetComponent<Transform>().position = target.position + offset;
	}

}
