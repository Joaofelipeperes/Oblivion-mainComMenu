using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public MeshRenderer mr;
    public float speedX;
    public float speedY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mr.material.mainTextureOffset += new Vector2(speedX * Time.deltaTime, speedY * Time.deltaTime);
    }

}
