﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour
{
	public Renderer rend;
	public Color aliveColor;
	public Color deadColor;
	public Color everAliveColor;

	public int x = -1;
	public int y = -1;

	float goalHeight = 1;
	float growSpeed = 0.7f;


	Vector3 startPosition;

	bool everAlive = false;
	public bool nextAlive;
	private bool _alive = false;
    public bool Alive
    {
        get
        {
            return this._alive;
        }
        set
        {
            this._alive = value;
            
            if (this._alive) {
				everAlive = true;
				rend.material.color = aliveColor;

				goalHeight += 1;
			} else {
				if (everAlive) {
					rend.material.color = everAliveColor;
				} else {
					rend.material.color = deadColor;
				}
			}
		}
    }

    // Start is called before the first frame update
    void Start()
    {
		startPosition = transform.position;

		this.Alive = Random.value < 0.4f;
    }

    // Update is called once per frame
    void Update()
    {
    
		float actualGrowSpeed = growSpeed;
    	if (!this.Alive) {
			actualGrowSpeed *= -1;
		}
		if (transform.localScale.y < goalHeight) {
			float newHeight = transform.localScale.y + actualGrowSpeed * Time.deltaTime;
			newHeight = Mathf.Clamp(newHeight, 1, 30);
			transform.localScale = new Vector3(transform.localScale.x, newHeight, transform.localScale.z);
		}
		
		
		if (transform.position.y < -10) {

			transform.position = startPosition;
		}
	}

	private void OnMouseDown()
	{
		this.Alive = !this.Alive;
	}

}
