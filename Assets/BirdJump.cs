using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour {
    public Rigidbody2D rb;
    public float jumpPower = 5.0f;

    void Start() {
        rb = GetComponent<Rigidbody2D>();   // Bird의 Rigidbody2D 컴포넌트를 가져옴
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {  // 마우스를 누른 순간에
            rb.velocity = Vector2.up * jumpPower;   // rb 내 속도값을 위쪽 방향으로 3만큼 설정
        }
    }
}
