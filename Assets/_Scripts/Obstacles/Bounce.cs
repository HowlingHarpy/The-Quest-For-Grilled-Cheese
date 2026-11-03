using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
	public float force = 10f; //Force 10000f
	public float stunTime = 0.5f;
	private Vector3 hitDir;

	//public CharacterControls playerControls;
	public CharacterController characterController;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            hitDir = other.transform.position - transform.position;
            hitDir.Normalize();
            //other.gameObject.GetComponent<CharacterControls>().HitPlayer(hitDir * force, stunTime);
            //other.gameObject.GetComponent<CharacterControls>().HitPlayer(hitDir * force, stunTime);
			//other.gameObject.transform.parent.GetComponent<CharacterControls>().HitPlayer(hitDir * force, stunTime);
            //playerControls.HitPlayer(hitDir * force, stunTime);
			characterController.Move(hitDir * force * Time.deltaTime);
        }
    }

 //   void OnCollisionEnter(Collision collision)
	//{
	//	foreach (ContactPoint contact in collision.contacts)
	//	{
	//		Debug.DrawRay(contact.point, contact.normal, Color.white);
	//		if (collision.gameObject.tag == "Player")
	//		{
	//			hitDir = contact.normal;
	//			collision.gameObject.GetComponent<CharacterControls>().HitPlayer(-hitDir * force, stunTime);
	//			return;
	//		}
	//	}
		/*if (collision.relativeVelocity.magnitude > 2)
		{
			if (collision.gameObject.tag == "Player")
			{
				//Debug.Log("Hit");
				collision.gameObject.GetComponent<CharacterControls>().HitPlayer(-hitDir*force, stunTime);
			}
			//audioSource.Play();
		}*/
	//}
}
