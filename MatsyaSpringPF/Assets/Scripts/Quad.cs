using UnityEngine;
using System.Collections;

public class Quad : MonoBehaviour 
{

	public float _sensitivity;
	private Vector3 _mouseReference;
	private Vector3 _mouseOffset;
	private Vector3 _rotation;
	private bool _isRotating;
	private Vector3 _clickDrag;
	void Start ()
	{
		_sensitivity = 0.4f;
		_rotation = Vector3.zero;
	}
	
	void Update()
	{
		_clickDrag = Camera.main.ScreenToViewportPoint (Input.mousePosition);

		if(_isRotating)
		{
			// offset
			_mouseOffset = (Input.mousePosition - _mouseReference);
			
			// apply rotation
			if (_clickDrag.y > 0.5)
			{
				if (_clickDrag.x > 0.5)
				{
				_rotation.y = (-_mouseOffset.x + _mouseOffset.y) * _sensitivity;
				}
				else
				{
				_rotation.y = - (_mouseOffset.x + _mouseOffset.y) * _sensitivity;
				}
			}
			else if (_clickDrag.x > 0.5)
			{
				_rotation.y = (_mouseOffset.x + _mouseOffset.y) * _sensitivity;
			}
			else
			{
				_rotation.y = (_mouseOffset.x - _mouseOffset.y) * _sensitivity;
			}
			// rotate
			transform.Rotate(_rotation);
			
			// store mouse
			_mouseReference = Input.mousePosition;
		}
	}
	
	void OnMouseDown()
	{
		// rotating flag
		_isRotating = true;
		
		// store mouse
		_mouseReference = Input.mousePosition;
	}
	
	void OnMouseUp()
	{
		// rotating flag
		_isRotating = false;
	}
	
}

/*Extra Notes
 * 
 * 
 * 
 * 
 * 
using UnityEngine;
using System.Collections;
public class DragAndDrop : MonoBehaviour {
	private Vector3 screenPoint, offset;
	
	void OnMouseDown() { //Select object
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
		                                                                                    Input.mousePosition.y, screenPoint.z));
	}
	void OnMouseDrag() {
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset - new Vector3(0,0, - 0.8561556f);
		transform.parent.position = curPosition;
	}
}
*/