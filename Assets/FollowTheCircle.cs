using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTheCircle : MonoBehaviour
{
	// Start is called before the first frame update

	public Transform circleTransform;
	private Vector3 _cameraOffset;
	[Range(0.01f, 1.0f)]
	public float smoothFactor = 0.5f;

	void Start()
	{
		_cameraOffset = transform.position - circleTransform.position;
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 newPos = circleTransform.position + _cameraOffset;
		transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
	}
}
