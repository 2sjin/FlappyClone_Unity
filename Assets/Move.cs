using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float speed = 1.5f;

    void Start() {

    }

    void Update() {
        // 파이프를 왼쪽으로 1 * speed 만큼 이동
        // 기기 성능에 따른 프레임 차이를 보정하기 위한 deltaTime을 곱하였음
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
