using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController: MonoBehaviour {

    /// <summary>
    /// 球のRigidbody
    /// </summary>
    private Rigidbody m_sphereRigidBody;

    /// <summary>
    /// キーボードのインプットを代入するVector3
    /// </summary>
    private Vector3 m_inputAxis = Vector3.zero;

    /// <summary>
    /// 球の加速度
    /// </summary>
    public float SphereAcceleration = 1.0f;

	void Start ()
    {
        m_sphereRigidBody = this.GetComponent<Rigidbody>();
        Time.timeScale = 1.0f;
	}

    private void FixedUpdate()
    {
        m_inputAxis.Set(Input.GetAxis("Horizontal") * SphereAcceleration, 0, Input.GetAxis("Vertical") * SphereAcceleration);
        m_sphereRigidBody.AddForce(m_inputAxis);

}
}
