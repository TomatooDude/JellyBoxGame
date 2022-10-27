
using UnityEngine;
using UnityEngine.SceneManagement;


public class CubeMove : MonoBehaviour
{
	[SerializeField] KeyCode KeyOne;
	[SerializeField] KeyCode KeyTwo;
	[SerializeField] Vector3 MoveDirection;
	[SerializeField] Rigidbody CubeRigidBody;

	private void Start ()
	{
		GetComponent<Rigidbody>();
	}

	private void FixedUpdate ()
	{
		if(Input.GetKey(KeyOne))
		{
			CubeRigidBody.velocity -= MoveDirection;
		}
		if(Input.GetKey(KeyTwo))
		{
			CubeRigidBody.velocity += MoveDirection;
		}
	}

	private void OnTriggerEnter (Collider other)
	{
		if(this.CompareTag("Player")&& other.CompareTag("Finish"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
		}
	}


}