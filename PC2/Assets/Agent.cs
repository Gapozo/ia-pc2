using UnityEngine;

public class Agent : SBAgent
{
	public Transform target;
	public Transform target2;

	void Start()
	{
		maxSpeed = 10f;
		maxSteer = 0.5f;

		target2 = GameObject.Find("Target2").transform;
	}

	void Update()
	{
		velocity += SteeringBehaviours.Arrive(this, target, 3);
			
		
		velocity += SteeringBehaviours.EnCirculo(this,target,target2,4.4f);
		velocity += SteeringBehaviours.ElCuadrado(this,target,target2,2,2);

		transform.position += velocity * Time.deltaTime;
	}
}
