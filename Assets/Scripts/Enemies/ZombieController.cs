using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour
{
    public int ZombieType = 0;
    public Animator anim;
    public float speed,damage;

    public Collider collider;

    private bool isAlive = true, isAttacking;

    void Update()
    {
        if (isAlive)
        {
            if (isAttacking)
            {
                transform.LookAt(GameManager.Instance.player.transform);
                var rot = transform.localEulerAngles;
                rot.x = rot.z = 0;
                transform.localEulerAngles = rot;
            }
            else if (ZombieType == 1)
            {
                transform.Translate(transform.forward * -speed);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(isAlive && other.CompareTag("Player"))
        {
            isAttacking = true;
            anim.SetInteger("State", (int)AnimationState.ATTACK);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isAlive && collision.gameObject.CompareTag("Bullet"))
        {
            isAlive = false;
            Destroy(collision.transform.parent.gameObject);
            anim.SetInteger("State", (int)AnimationState.DEATH);
            collider.enabled = false;
        }
    }

    public void GiveDamage()
    {
        GameManager.Instance.player.GiveDamage(damage);
    }
}