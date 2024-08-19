using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    Material material;
    const float speed = 0.1f;
    Vector2 offset;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset.y += speed * Time.deltaTime;
        material.SetTextureOffset("_MainTex", offset);
    }
}
