using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //RayCast();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ClickToRayCast();
        }
    }

    Vector3 ClickToRayCast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Debug.Log("Raycast");
            return hit.point;
        }

        Debug.Log("Fail");
        return Vector3.zero;
    }
}
