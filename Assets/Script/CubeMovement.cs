
using UnityEngine;
using UnityEngine.SceneManagement;


public class CubeMovement : MonoBehaviour
{
	[SerializeField] KeyCode _keyOne;
	[SerializeField] KeyCode _keyTwo;
	[SerializeField] Vector3 _moveDirection;
	[SerializeField] Rigidbody _cubeRigidBody;
	[SerializeField] public float _moveForce = 0.2f;

	private void Start ()
	{
		GetComponent<Rigidbody>();
	}

	private void FixedUpdate ()
	{
		Move();

	}
	private void Update ()
	{
		Restart();
	}

	private void Move ()
	{
		if(Input.GetKey(_keyOne))
		{
			_cubeRigidBody.velocity -= _moveDirection * _moveForce;
		}
		if(Input.GetKey(_keyTwo))
		{
			_cubeRigidBody.velocity += _moveDirection * _moveForce;
		}
	}

	private void Restart()
	{
		if(Input.GetKey(KeyCode.R))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
