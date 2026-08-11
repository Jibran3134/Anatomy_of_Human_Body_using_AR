using UnityEngine;

public class OrganTouchController : MonoBehaviour
{
	public float minScaleMultiplier = 0.3f;
	public float maxScaleMultiplier = 3f;
	public float rotationSpeed = 0.5f;

	Vector3 baseScale;
	bool dragging;
	Vector3 dragOffset;
	float pinchStartDistance;
	Vector3 pinchStartScale;
	float lastPinchAngle;

	void Start()
	{
		baseScale = transform.localScale;
	}

	void Update()
	{
		if (Input.touchCount == 1)
		{
			HandleDrag(Input.GetTouch(0));
		}
		else if (Input.touchCount == 2)
		{
			dragging = false;
			HandlePinchAndRotate(Input.GetTouch(0), Input.GetTouch(1));
		}
		else
		{
			dragging = false;
		}
	}

	void HandleDrag(Touch touch)
	{
		if (touch.phase == TouchPhase.Began)
		{
			Ray ray = Camera.main.ScreenPointToRay(touch.position);
			if (Physics.Raycast(ray, out RaycastHit hit) && hit.transform.IsChildOf(transform))
			{
				dragging = true;
				Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
				dragOffset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, screenPoint.z));
			}
		}
		else if (dragging && touch.phase == TouchPhase.Moved)
		{
			Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
			transform.position = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, screenPoint.z)) + dragOffset;
		}
		else if (touch.phase == TouchPhase.Ended || touch.phase == TouchPhase.Canceled)
		{
			dragging = false;
		}
	}

	void HandlePinchAndRotate(Touch t0, Touch t1)
	{
		Vector2 currentVector = t1.position - t0.position;
		float currentDistance = currentVector.magnitude;
		float currentAngle = Mathf.Atan2(currentVector.y, currentVector.x) * Mathf.Rad2Deg;

		if (t0.phase == TouchPhase.Began || t1.phase == TouchPhase.Began)
		{
			pinchStartDistance = currentDistance;
			pinchStartScale = transform.localScale;
			lastPinchAngle = currentAngle;
			return;
		}

		if (pinchStartDistance > 0f)
		{
			float factor = currentDistance / pinchStartDistance;
			Vector3 targetScale = pinchStartScale * factor;
			float multiplier = Mathf.Clamp(targetScale.x / baseScale.x, minScaleMultiplier, maxScaleMultiplier);
			transform.localScale = baseScale * multiplier;
		}

		float deltaAngle = Mathf.DeltaAngle(lastPinchAngle, currentAngle);
		transform.Rotate(Vector3.up, -deltaAngle * rotationSpeed, Space.World);
		lastPinchAngle = currentAngle;
	}
}
