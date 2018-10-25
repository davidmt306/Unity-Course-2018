﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    // Configuration parameters
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float xPadding = 0.8f;
    [SerializeField] float yPadding = 1f;
    [SerializeField] GameObject laserPrefab;
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] float projectileFirePeriod = 0.1f;

    Coroutine firingCoroutine;

    float xMin;
    float xMax;

    float yMin;
    float yMax;

	// Use this for initialization
	void Start () {
        SetUpMoveBoundaries();
	}

    // Update is called once per frame
    void Update () {
        Move();
        Fire();
	}

    // Fire the player laser
    private void Fire() {
        if (Input.GetButtonDown("Fire1")) {
            firingCoroutine = StartCoroutine(FireContinuously());
        }
        if (Input.GetButtonUp("Fire1")) {
            StopCoroutine(firingCoroutine);
        }
    }

    IEnumerator FireContinuously () {
        while (true) {
            GameObject laser = Instantiate(laserPrefab, transform.position, Quaternion.identity) as GameObject;
            laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, projectileSpeed);
            yield return new WaitForSeconds(projectileFirePeriod);
        }
    }

    // Move the player ship
    private void Move() {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var deltaY = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        var newXPos = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);
        var newYPos = Mathf.Clamp(transform.position.y + deltaY, yMin, yMax);
        transform.position = new Vector2(newXPos, newYPos);
    }

    // Set the boundaries (limits) of the game
    private void SetUpMoveBoundaries() {
        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + xPadding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - xPadding;

        yMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + yPadding;
        yMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - yPadding;
    }
}
