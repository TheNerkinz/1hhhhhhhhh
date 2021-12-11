using UnityEngine;

public class GrabSystem : MonoBehaviour
{
	public Transform camera;

	private Interactable _interactable;
	
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			camera.gameObject.SetActive(true);
			Ray ray = new Ray(camera.position, camera.forward);

			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 100))
			{
				_interactable = raycastHit.collider.GetComponent<Interactable>();
				if (_interactable != null)
				{
					_interactable.Follow(camera);
				}
			}
		}

		if (Input.GetMouseButtonUp(0))
		{
			if (_interactable != null)
			{
				_interactable.Drop();
				_interactable = null;
			}
		} 
	}
}
