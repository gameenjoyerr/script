using system.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehvaviour
public interface health
public float speed = 1f;
float borderPosX;
public Animator animator;
public floatshootInterval = 1f;
public float shootTimer = 0f;
private void Update()
if (shootTimer > 0)
shootTimer.deltaTime;
float enemy PosX = transform position X;
if (enemyPosX = borderPosX)
animation SetBool("IsMoving"= true)
transform position += transform.right* *speed Time.deltaTime
else
{
    animation.SetBool()
}