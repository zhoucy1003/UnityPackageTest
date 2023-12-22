using UnityEngine;

public class TestSampleRes : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        var obj = Resources.Load("Textures/Tex") as Texture2D;
        Debug.Log(obj);
        m_mat.SetTexture("_MainTex", obj);
    }
    public Material m_mat;
}
