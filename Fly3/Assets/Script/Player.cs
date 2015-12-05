using UnityEngine;
using System.Collections;
[AddComponentMenu("MYGame/Player")]

public class Player : MonoBehaviour {
	
	// 移动速度
	public float m_speed = 10;
	
	protected Transform m_transform;

	public Transform m_rocket;

	// Use this for initialization
	void Start () {
		m_transform = this.transform;
	}
	 
	// Update is called once per frame
	void Update () {
		
		// 纵向移动距离
		float movev = 0;
		
		// 水平移动距离
		float moveh = 0;
		
		// 按上键
		if (Input.GetKey (KeyCode.UpArrow)) {
			movev -= m_speed * Time.deltaTime;
		}
		
		if (Input.GetKey (KeyCode.DownArrow)) {
			movev += m_speed * Time.deltaTime;		
		}
		
		if (Input.GetKey (KeyCode.LeftArrow)) {
			moveh += m_speed * Time.deltaTime;
		}
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			moveh -= m_speed * Time.deltaTime;
		}
		
		this.m_transform.Translate (new Vector3 (moveh, 0, movev));

		if (Input.GetKey (KeyCode.Space)) {
			Instantiate(m_rocket, m_transform.position, m_transform.rotation);
		}
		
	}
}
