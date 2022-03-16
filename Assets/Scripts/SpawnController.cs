using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public float blockSpacing;
    public Vector2 blockNums;
    public static Vector2 blockScale;
    public GameObject hm;
    // Start is called before the first frame update
    void Start()
    {
        CalcTileSize();
    }
    
    void CalcTileSize() {
        float height = Camera.main.orthographicSize * 2.0f;
        float width = height * Camera.main.aspect;
        /*
        GameObject test = Instantiate(hm, Vector3.zero, Quaternion.Euler(Vector3.zero));
        hm.transform.localScale = new Vector3(width, height, 1);*/
    }
}