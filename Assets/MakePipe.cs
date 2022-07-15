using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour {
    public GameObject pipe;

    private float pipePositionMin = -1.0f;
    private float pipePositionMax = 2.0f;

    public float timeDiff;
    
    float timer = 0;
    
    void Start() {

    }

    void Update() {

        timer += Time.deltaTime;

        if (timer > timeDiff) {
            GameObject newpipe = Instantiate(pipe);

            newpipe.transform.position = new Vector3(5, Random.Range(pipePositionMin, pipePositionMax), 0);
            timer = 0;

            Destroy(newpipe, 6.0f);    // 7초 후 파이프 제거
        }
    }
}
