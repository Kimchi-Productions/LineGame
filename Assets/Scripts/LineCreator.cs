using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreator : MonoBehaviour {

	public GameObject linePrefab;

	Line activeLine;

	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			GameObject lineGO = Instantiate(linePrefab);
			activeLine = lineGO.GetComponent<Line>();
		}

		if (Input.GetMouseButtonUp(0))
		{
            activeLine.gameObject.AddComponent<Rigidbody2D>();
            activeLine.GetComponent<Rigidbody2D>().centerOfMass = GetBoundsCenter(activeLine.transform);
            activeLine = null;
		}

		if (activeLine != null)
		{
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			activeLine.UpdateLine(mousePos);
		}

	}

    public Vector2 GetBoundsCenter(Transform t)
    {
        Renderer r = t.GetComponent<Renderer>();
        if (r != null)
        {
            return r.bounds.center;
        }
        else
        {
            return t.position;
        }
    }

}
