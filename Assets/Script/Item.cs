using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	// アイテムの接触時に呼ばれるコールバック
	void OnTriggerEnter(Collider hit) {
		// 接触判定をプレイヤーのみに限定する
		if (hit.CompareTag ("Player")) {
			// 削除する
			Destroy (gameObject);
		}
	}
}
