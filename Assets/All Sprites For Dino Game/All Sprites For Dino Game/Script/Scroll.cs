using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    // Start is called before the first frame update
    public Material material; //Unity needs material to be attached to
    public float xVel = 0.1f; //Setting our start point 0.1 units away
    Vector2 offset;
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(xVel, 0);
        material.mainTextureOffset += offset * Time.deltaTime; //Updating textures with offset update every 0.1 seconds

    }
}
