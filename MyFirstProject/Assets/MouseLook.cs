using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public RotationAxes axes = RotationAxes.MouseXAndY;

    public float sensitivityHorizontal = 9.0f;
    public float sensitivityVertical = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float _rotationX = 0;

    // Use this for initialization
    void Start () {
        Debug.Log("Starting MouseLook Script!");
	}
	
	// Update is called once per frame
	void Update () {
        if (axes == RotationAxes.MouseX)
        {
            // horizontal rotation here
            Debug.Log("MouseLook Horizontal Rotation");
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHorizontal, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            // vertical rotation here
            Debug.Log("MouseLook Vertical Rotation");
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVertical;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            transform.Rotate(-(Input.GetAxis("Mouse Y") * sensitivityVertical), 0, 0);
        }
        else
        {
            // both horizontal and vertical rotation here
            Debug.Log("MouseLook both Horizontal and Vertical Rotation");
        }
    }
}
