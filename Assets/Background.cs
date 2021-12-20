using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject linePrefab;
    private Line activeLine;
    private Transform transformer;
    void Start()
    {
        GameObject lineGO = Instantiate(linePrefab);
        activeLine = lineGO.GetComponent<Line>();
        transformer = GetComponent<Transform>();

        Vector3 size = transform.localScale;

        float X = size.x;
        float Y = size.y;
        float Z = size.z;

        Vector2 pos = new Vector2(-350f, -400f);
        activeLine.UpdateLine(pos);
        
        pos = new Vector2(-350f, 400f);
        activeLine.UpdateLine(pos);

        pos = new Vector2(-350f, 400f);
        activeLine.UpdateLine(pos);

        pos = new Vector2(350f, 400f);
        activeLine.UpdateLine(pos);

        pos = new Vector2(350f, -400f);
        activeLine.UpdateLine(pos);

        pos = new Vector2(-350f, -400f);
        activeLine.UpdateLine(pos);

        /*for (int i=0; i < 10; i++) {
            Vector2 pos = new Vector2((float)30*i, 90f);
            activeLine.UpdateLine(pos);
        }*/

        activeLine = null;
    }
}
