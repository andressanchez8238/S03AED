using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string EnemyName;
    public int Life;
    public int Str;

    public Material Mat;

    void Start()
    {
        Mat = GetComponent<Material>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetMat(Color color)
    {
        Mat.color = color;
    }
}
