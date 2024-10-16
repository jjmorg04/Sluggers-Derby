using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SluggersDerby : MonoBehaviour {
    public GameObject baseballBat;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;

    void Start() {
        
        GameObject bbBat = Instantiate<GameObject>(baseballBat);
        Vector3 pos = Vector3.zero;
        bbBat.transform.position = pos;
        }

}