using UnityEngine;
using System.Collections;
public class Colors : MonoBehaviour
{

    public Color color;
    public float time = 3.0f;
    public float amount = 0.0f;
    public HSBColor hsbc;

    void Start()
    {
        //color = gameObject.GetComponent<SpriteRenderer>().color;
        color = Color.white;
        hsbc = HSBColor.FromColor(color);
        sColor = this.GetComponent<SpriteRenderer>();
        hsbc.s = 1;
        hsbc.b = 1;
        hsbc.a = 1;
        
    }
    SpriteRenderer sColor;
    void Update()
    {
        
        hsbc.h = (hsbc.h + Time.deltaTime / time) % 1.0f;
        sColor.color = Color.Lerp(color, HSBColor.ToColor(hsbc), amount);
    }
}