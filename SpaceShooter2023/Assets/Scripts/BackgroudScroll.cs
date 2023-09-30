using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroudScroll : MonoBehaviour
{
    private Renderer bgRenderer;
    [SerializeField] private Vector2 velocity;
    // Start is called before the first frame update
    void Start()
    {
        bgRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * velocity.x,Time.time * velocity.y);
        bgRenderer.material.mainTextureOffset = offset;
    }
}
